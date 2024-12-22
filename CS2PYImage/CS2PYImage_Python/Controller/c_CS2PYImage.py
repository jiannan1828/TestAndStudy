from PyQt5.QtCore import *  # �ϥ� from xxx import * �i�H���Υ��Ҳիe��W��
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
        ## �b�o�̥[�J������������������ƥ�
        self.ui.btn_ReadImage.clicked.connect(self.btn_ReadImage_Clicked) 

    def btn_ReadImage_Clicked(self):
        # �@�ɰO����W�٩M�j�p
        SHARED_MEMORY_NAME = "SharedMemory"  # �P C# �����W�٤@�P
        SHARED_MEMORY_SIZE = 1024 * 1024  # �P C# ���]�w���j�p�@�P (1MB)

        # Ū���@�ɰO����ƾ�
        with mmap.mmap(-1, SHARED_MEMORY_SIZE, SHARED_MEMORY_NAME) as shared_mem:

            # �q�@�ɰO����Ū���ƾ�
            image_bytes = shared_mem[:SHARED_MEMORY_SIZE]

            # 1. �N�r�`�ƾ��ഫ�� NumPy �}�C
            image_np = np.frombuffer(image_bytes, dtype=np.uint8)

            # 2. �ϥ� cv2.imdecode �ѽX
            image = cv2.imdecode(image_np, cv2.IMREAD_COLOR)

            # �{�b image �O�@�ӸѽX�᪺ NumPy �}�C�A�i�H�Ω���ܩζi�@�B�B�z
            cv2.imshow("Image", image)
            cv2.waitKey(0)
            cv2.destroyAllWindows()