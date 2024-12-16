from PyQt5.QtCore import *  # �ϥ� from xxx import * �i�H���Υ��Ҳիe��W��
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from Controller.c_Main import *
from View.v_ThreadTest import *
from Model.m_ThreadTest import *

import threading
import time


class ThreadTest(QMainWindow): # PyQtMVC �~�� QMainWindow 
    def __init__(self, parent): # �p�G�S���������w�]�� null
        super(QMainWindow, self).__init__(parent) # �d�� QMainWindow ���Ҧ�����, �åB�a�J����������Ҧ���l�ƨ禡
        self.ui = Ui_ThreadTest() # ��q .ui �ഫ�� .py �Ҫ����O
        self.ui.setupUi(self) # ��l�Ƶ�����������
        self.linkEvent() # �Хߨƥ�s��

    def linkEvent(self):
        ## �b�o�̥[�J������������������ƥ�
        self.ui.btn_Thread1.clicked.connect(lambda: btn_Thread1_Clicked(self)) # ���U���s�ƥ�
        self.ui.btn_Thread2.clicked.connect(lambda: btn_Thread2_Clicked(self)) # ���U���s�ƥ�

def btn_Thread1_Clicked(sender):
    Thread1 = threading.Thread(target = lambda: thread1(sender)) 
    Thread1.start()

def btn_Thread2_Clicked(sender):
    Thread2 = threading.Thread(target = lambda: thread2(sender))
    Thread2.start()

def thread1(sender):
    i = 0
    while(True):
        i = i + 1
        time.sleep(1)
        sender.ui.lbl_Thread1.setText(str(i))
        
def thread2(sender):
    i = 0
    while(True):
        i = i + 2
        time.sleep(1)
        sender.ui.lbl_Thread2.setText(str(i))
        
           