import sys

from PyQt5.QtCore import *  # �ϥ� from xxx import * �i�H���Υ��Ҳիe��W��
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from Controller.c_RS232 import *

def main():
    app = QApplication(sys.argv)  # �����ϥ� QApplication�A�]���w�q QtWidgets �פJ

    main = RS232()
    main.show()

    sys.exit(app.exec_())  # �Ұ����ε{���ƥ�j��

if __name__ == "__main__": # ����檺�ɮצW�٨ëD main.py ��, ���|�۰ʰ���, �ȯ��ҲդޤJ
    main()


