# Controller/Hello_PyQt.py
from Model.m_Author import Author

def btn_PyQt_Clicked(sender):
    # �Ы� Author �������
    author = Author("John", 30, "Male")  # �ǤJ�A���Ѽ�
    author.introduce()  # �I�s introduce ��k

    sender.ui.lbl_Name.setText("Name : " + author.name)
    sender.ui.lbl_Age.setText("Age : " + str(author.age))
    sender.ui.lbl_Gender.setText("Gender : " + author.gender)