from PyQt5.QtCore import *  # 使用 from xxx import * 可以不用打模組前綴名稱
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from Controller.c_Main import *
from View.v_ThreadTest import *
from Model.m_ThreadTest import *

import threading
import time


class ThreadTest(QMainWindow): # PyQtMVC 繼承 QMainWindow 
    def __init__(self, parent): # 如果沒有父視窗預設為 null
        super(QMainWindow, self).__init__(parent) # 查找 QMainWindow 的所有父類, 並且帶入父視窗執行所有初始化函式
        self.ui = Ui_ThreadTest() # 剛從 .ui 轉換成 .py 黨的類別
        self.ui.setupUi(self) # 初始化視窗內部元件
        self.linkEvent() # 創立事件連結

    def linkEvent(self):
        ## 在這裡加入視窗內部元件對應的事件
        self.ui.btn_Thread1.clicked.connect(lambda: btn_Thread1_Clicked(self)) # 註冊按鈕事件
        self.ui.btn_Thread2.clicked.connect(lambda: btn_Thread2_Clicked(self)) # 註冊按鈕事件

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
        
           