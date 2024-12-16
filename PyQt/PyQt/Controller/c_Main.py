from PyQt5.QtCore import *  # �ϥ� from xxx import * �i�H���Υ��Ҳիe��W��
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from View.v_Main import *
from Model.m_Main import *
from Controller.c_ThreadTest import *

class Main(QMainWindow): # PyQtMVC �~�� QMainWindow 
    def __init__(self, parent = None): # �p�G�S���������w�]�� null
        super(QMainWindow, self).__init__(parent) # �d�� QMainWindow ���Ҧ�����, �åB�a�J����������Ҧ���l�ƨ禡
        self.ui = Ui_Main() # ��q .ui �ഫ�� .py �Ҫ����O
        self.ui.setupUi(self) # ��l�Ƶ�����������
        self.linkEvent() # �Хߨƥ�s��

    def linkEvent(self):
        ## �b�o�̥[�J������������������ƥ�
        self.ui.btn_PyQt.clicked.connect(lambda: btn_PyQt_Clicked(self)) # ���U���s�ƥ�
        self.ui.btn_Thread.clicked.connect(lambda: btn_Thread_Clicked(self)) # ���U���s�ƥ�

def btn_PyQt_Clicked(sender):
    # �Ы� Author �������
    author = Author("John", 30, "Male")  # �ǤJ�A���Ѽ�
    author.introduce()  # �I�s introduce ��k

    sender.ui.lbl_Name.setText("Name : " + author.name)
    sender.ui.lbl_Age.setText("Age : " + str(author.age))
    sender.ui.lbl_Gender.setText("Gender : " + author.gender)

def btn_Thread_Clicked(sender):
    threadtest = ThreadTest(sender)
    threadtest.show()
    
    



