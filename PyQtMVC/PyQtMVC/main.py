import sys

from PyQt5.QtCore import *  # 使用 from xxx import * 可以不用打模組前綴名稱
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from Model.Author import *
from View.Hello_PyQt import *
from Controller.Hello_PyQt import *

class PyQtMVC(QMainWindow): # PyQtMVC 繼承 QMainWindow 
    def __init__(self, parent = None): # 如果沒有父視窗預設為 null
        super(QMainWindow, self).__init__(parent) # 查找 QMainWindow 的所有父類, 並且帶入父視窗執行所有初始化函式
        self.ui = Ui_PyQtMVC() # 剛從 .ui 轉換成 .py 黨的類別
        self.ui.setupUi(self) # 初始化視窗內部元件
        self.linkEvent() # 創立事件連結

    def linkEvent(self):
        ## 在這裡加入視窗內部元件對應的事件
        self.ui.btn_PyQt.clicked.connect(lambda: btn_PyQt_Clicked(self)) # 註冊按鈕事件

def main():
    app = QApplication(sys.argv)  # 直接使用 QApplication，因為已從 QtWidgets 匯入

    main = PyQtMVC()
    main.show()

    sys.exit(app.exec_())  # 啟動應用程式事件迴圈

if __name__ == "__main__":
    main()
