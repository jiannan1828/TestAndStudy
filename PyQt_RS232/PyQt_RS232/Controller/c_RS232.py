import serial   
import serial.tools.list_ports
import threading

from PyQt5.QtCore import *  
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *

from View.v_RS232 import Ui_RS232

class RS232(QMainWindow): 
    def __init__(self, parent = None): 
        super(QMainWindow, self).__init__(parent) 
        self.ui = Ui_RS232() 
        self.ui.setupUi(self) 
        self.linkEvent() 

        self.ui.btn_Disconnect.setEnabled(False)  
        self.ui.btn_SendMessage.setEnabled(False)

        self.ser = serial.Serial()
        Enable_ports = list(serial.tools.list_ports.comports())
        for port in Enable_ports:
            self.ui.cmb_Port.addItem(port.name)

    def linkEvent(self):
        ## 在這裡加入視窗內部元件對應的事件
        self.ui.btn_Connect.clicked.connect(self.btn_Connect_Clicked) 
        self.ui.btn_Disconnect.clicked.connect(self.btn_Disconnect_Clicked)
        self.ui.btn_SendMessage.clicked.connect(self.btn_SendMessage_Clicked)


    def btn_Connect_Clicked(self):

        self.ser.port = self.ui.cmb_Port.currentText()
        self.ser.baudrate = 9600
        self.ser.bytesize=serial.EIGHTBITS  # 數據位 8
        self.ser.parity=serial.PARITY_NONE # 無校驗位
        self.ser.stopbits=serial.STOPBITS_ONE  # 停止位 1
        self.ser.timeout = 1           # 超時設置為1秒

        self.ser.open()

        self.ui.btn_Connect.setEnabled(False) 
        self.ui.btn_Disconnect.setEnabled(True)  
        self.ui.btn_SendMessage.setEnabled(True)
        self.ui.cmb_Port.setEnabled(False)

        data_Received_Listener = threading.Thread(target = self.data_Received_Handler) 
        data_Received_Listener.start()

    def data_Received_Handler(self):

        received_data_buffer = b""  # 用來保存接收到的所有字節數據

        while self.ser.is_open:
            try:
                if self.ser.in_waiting > 0:
                    received_data = self.ser.read(self.ser.in_waiting)  # 讀取所有可用的數據, 並清空暫存區
                    try:
                        received_data_buffer += received_data
                        decoded_data = received_data_buffer.decode('utf-8')  # 將字節數據解碼為字符串
                    except UnicodeDecodeError:  # 解碼錯誤, 暫存區未包含完整數據
                        continue  # 跳過錯誤的數據
                    if "\r" in decoded_data:  # 檢查是否包含 \r
                        self.ui.rtb_ReceiveMessage.append(decoded_data.rstrip()) 
                        received_data_buffer = b""
            except:
                break;

    def btn_Disconnect_Clicked(self):
        self.ser.close()

        self.ui.btn_Connect.setEnabled(True) 
        self.ui.btn_Disconnect.setEnabled(False)  
        self.ui.btn_SendMessage.setEnabled(False)
        self.ui.cmb_Port.setEnabled(True)

    def btn_SendMessage_Clicked(self):
        self.ser.write((self.ui.txt_SendMessage.text() + "\r").encode('utf-8')) # 將字符串數據解碼為字節
            
          
