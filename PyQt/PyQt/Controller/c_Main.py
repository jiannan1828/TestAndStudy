from PyQt5.QtCore import *  # 使用 from xxx import * 可以不用打模組前綴名稱
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from View.v_Main import *
from Model.m_Main import *
from Controller.c_ThreadTest import *

class Main(QMainWindow): # PyQtMVC 繼承 QMainWindow 
    def __init__(self, parent = None): # 如果沒有父視窗預設為 null
        super(QMainWindow, self).__init__(parent) # 查找 QMainWindow 的所有父類, 並且帶入父視窗執行所有初始化函式
        self.ui = Ui_Main() # 剛從 .ui 轉換成 .py 黨的類別
        self.ui.setupUi(self) # 初始化視窗內部元件
        self.linkEvent() # 創立事件連結

    def linkEvent(self):
        ## 在這裡加入視窗內部元件對應的事件
        self.ui.btn_PyQt.clicked.connect(lambda: btn_PyQt_Clicked(self)) # 註冊按鈕事件
        self.ui.btn_Thread.clicked.connect(lambda: btn_Thread_Clicked(self)) # 註冊按鈕事件

def btn_PyQt_Clicked(sender):
    # 創建 Author 類的實例
    author = Author("John", 30, "Male")  # 傳入適當的參數
    author.introduce()  # 呼叫 introduce 方法

    sender.ui.lbl_Name.setText("Name : " + author.name)
    sender.ui.lbl_Age.setText("Age : " + str(author.age))
    sender.ui.lbl_Gender.setText("Gender : " + author.gender)

def btn_Thread_Clicked(sender):
    threadtest = ThreadTest(sender)
    threadtest.show()
    
    



