from PyQt5.QtCore import *  # �ϥ� from xxx import * �i�H���Υ��Ҳիe��W��
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
        # �@�ɰO����W�٩M�j�p
        SHARED_MEMORY_NAME = "CS2PYImage"  # �P C# �����W�٤@�P
        SHARED_MEMORY_SIZE = 10 * 1024 * 1024  # �P C# ���]�w���j�p�@�P (10MB)

        # Ū���@�ɰO����ƾ�, -1 �N���h�M�g������, �Ыؤ@�ӪŪ��O����Ŷ�
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

    def btn_ReadJson_Clicked(self):
        SHARED_MEMORY_NAME = "CS2PYJson"  
        SHARED_MEMORY_SIZE = 1024 * 1024  

        with mmap.mmap(-1, SHARED_MEMORY_SIZE, SHARED_MEMORY_NAME) as shared_mem:
            Json_bytes = shared_mem[:SHARED_MEMORY_SIZE]

            # �h��������R�r�`�]�Ҧp \x00�^�A�T�O JSON �r�Ŧꪺ�������T
            json_str = Json_bytes.rstrip(b'\x00').decode('utf-8')

            data = json.loads(json_str)
            print(data)