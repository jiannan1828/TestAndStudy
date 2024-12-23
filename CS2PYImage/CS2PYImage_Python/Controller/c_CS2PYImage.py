from PyQt5.QtCore import *  # 使用 from xxx import * 可以不用打模組前綴名稱
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

import numpy as np
import cv2
import mmap
import json

from View.v_CS2PYImage import *
from Controller.c_CS2PYImage import *

class CS2PYImage(QMainWindow): 
    def __init__(self, parent = None): 
        super(QMainWindow, self).__init__(parent) 
        self.ui = Ui_CS2PYImage() 
        self.ui.setupUi(self) 
        self.linkEvent() 

    def linkEvent(self):
        self.ui.btn_ReadImage.clicked.connect(self.btn_ReadImage_Clicked) 
        self.ui.btn_ReadJson.clicked.connect(self.btn_ReadJson_Clicked) 


    def btn_ReadImage_Clicked(self):
        # 共享記憶體名稱和大小
        SHARED_MEMORY_NAME = "CS2PYImage"  # 與 C# 中的名稱一致
        SHARED_MEMORY_SIZE = 10 * 1024 * 1024  # 與 C# 中設定的大小一致 (10MB)

        # 讀取共享記憶體數據, -1 代表不去映射任何文件, 創建一個空的記憶體空間
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

    def btn_ReadJson_Clicked(self):
        SHARED_MEMORY_NAME = "CS2PYJson"  
        SHARED_MEMORY_SIZE = 1024 * 1024  

        with mmap.mmap(-1, SHARED_MEMORY_SIZE, SHARED_MEMORY_NAME) as shared_mem:
            Json_bytes = shared_mem[:SHARED_MEMORY_SIZE]

            # 去除尾部填充字節（例如 \x00），確保 JSON 字符串的結尾正確
            json_str = Json_bytes.rstrip(b'\x00').decode('utf-8')

            data = json.loads(json_str)
            print(data)