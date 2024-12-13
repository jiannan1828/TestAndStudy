# Controller/Hello_PyQt.py
from Model.m_Author import Author

def btn_PyQt_Clicked(sender):
    # 創建 Author 類的實例
    author = Author("John", 30, "Male")  # 傳入適當的參數
    author.introduce()  # 呼叫 introduce 方法

    sender.ui.lbl_Name.setText("Name : " + author.name)
    sender.ui.lbl_Age.setText("Age : " + str(author.age))
    sender.ui.lbl_Gender.setText("Gender : " + author.gender)