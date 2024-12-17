import sys

from PyQt5.QtCore import *  # 使用 from xxx import * 可以不用打模組前綴名稱
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from Controller.c_RS232 import *

def main():
    app = QApplication(sys.argv)  # 直接使用 QApplication，因為已從 QtWidgets 匯入

    main = RS232()
    main.show()

    sys.exit(app.exec_())  # 啟動應用程式事件迴圈

if __name__ == "__main__": # 當執行的檔案名稱並非 main.py 時, 不會自動執行, 僅能當模組引入
    main()


