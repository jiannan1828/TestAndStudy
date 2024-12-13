import sys

from PyQt5.QtCore import *  # �ϥ� from xxx import * �i�H���Υ��Ҳիe��W��
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from Model.Author import *
from View.Hello_PyQt import *
from Controller.Hello_PyQt import *

class PyQtMVC(QMainWindow): # PyQtMVC �~�� QMainWindow 
    def __init__(self, parent = None): # �p�G�S���������w�]�� null
        super(QMainWindow, self).__init__(parent) # �d�� QMainWindow ���Ҧ�����, �åB�a�J����������Ҧ���l�ƨ禡
        self.ui = Ui_PyQtMVC() # ��q .ui �ഫ�� .py �Ҫ����O
        self.ui.setupUi(self) # ��l�Ƶ�����������
        self.linkEvent() # �Хߨƥ�s��

    def linkEvent(self):
        ## �b�o�̥[�J������������������ƥ�
        self.ui.btn_PyQt.clicked.connect(lambda: btn_PyQt_Clicked(self)) # ���U���s�ƥ�

def main():
    app = QApplication(sys.argv)  # �����ϥ� QApplication�A�]���w�q QtWidgets �פJ

    main = PyQtMVC()
    main.show()

    sys.exit(app.exec_())  # �Ұ����ε{���ƥ�j��

if __name__ == "__main__":
    main()
