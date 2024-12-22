from PyQt5.QtCore import *  # 使用 from xxx import * 可以不用打模組前綴名稱
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

import numpy as np
import cv2
import mmap

from View.v_CS2PYImage import *
from Controller.c_CS2PYImage import *

class CS2PYImage(QMainWindow): 
    def __init__(self, parent = None): 
        super(QMainWindow, self).__init__(parent) 
        self.ui = Ui_CS2PYImage() 
        self.ui.setupUi(self) 
        self.linkEvent() 

    def linkEvent(self):
        ## 在這裡加入視窗內部元件對應的事件
        self.ui.btn_ReadImage.clicked.connect(self.btn_ReadImage_Clicked) 

    def btn_ReadImage_Clicked(self):
        # 共享記憶體名稱和大小
        SHARED_MEMORY_NAME = "SharedMemory"  # 與 C# 中的名稱一致
        SHARED_MEMORY_SIZE = 1024 * 1024  # 與 C# 中設定的大小一致 (1MB)

        # 讀取共享記憶體數據
        with mmap.mmap(-1, SHARED_MEMORY_SIZE, SHARED_MEMORY_NAME) as shared_mem:

            # 從共享記憶體讀取數據
            image_bytes = shared_mem[:SHARED_MEMORY_SIZE]

            # 1. 將字節數據轉換為 NumPy 陣列
            image_np = np.frombuffer(image_bytes, dtype=np.uint8)

            # 2. 使用 cv2.imdecode 解碼
            image = cv2.imdecode(image_np, cv2.IMREAD_COLOR)

            # 現在 image 是一個解碼後的 NumPy 陣列，可以用於顯示或進一步處理
            cv2.imshow("Image", image)
            cv2.waitKey(0)
            cv2.destroyAllWindows()