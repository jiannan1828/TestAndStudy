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
        ## �b�o�̥[�J������������������ƥ�
        self.ui.btn_Connect.clicked.connect(self.btn_Connect_Clicked) 
        self.ui.btn_Disconnect.clicked.connect(self.btn_Disconnect_Clicked)
        self.ui.btn_SendMessage.clicked.connect(self.btn_SendMessage_Clicked)


    def btn_Connect_Clicked(self):

        self.ser.port = self.ui.cmb_Port.currentText()
        self.ser.baudrate = 9600
        self.ser.bytesize=serial.EIGHTBITS  # �ƾڦ� 8
        self.ser.parity=serial.PARITY_NONE # �L�����
        self.ser.stopbits=serial.STOPBITS_ONE  # ����� 1
        self.ser.timeout = 1           # �W�ɳ]�m��1��

        self.ser.open()

        self.ui.btn_Connect.setEnabled(False) 
        self.ui.btn_Disconnect.setEnabled(True)  
        self.ui.btn_SendMessage.setEnabled(True)
        self.ui.cmb_Port.setEnabled(False)

        data_Received_Listener = threading.Thread(target = self.data_Received_Handler) 
        data_Received_Listener.start()

    def data_Received_Handler(self):

        received_data_buffer = b""  # �ΨӫO�s�����쪺�Ҧ��r�`�ƾ�

        while self.ser.is_open:
            try:
                if self.ser.in_waiting > 0:
                    received_data = self.ser.read(self.ser.in_waiting)  # Ū���Ҧ��i�Ϊ��ƾ�, �òM�żȦs��
                    try:
                        received_data_buffer += received_data
                        decoded_data = received_data_buffer.decode('utf-8')  # �N�r�`�ƾڸѽX���r�Ŧ�
                    except UnicodeDecodeError:  # �ѽX���~, �Ȧs�ϥ��]�t����ƾ�
                        continue  # ���L���~���ƾ�
                    if "\r" in decoded_data:  # �ˬd�O�_�]�t \r
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
        self.ser.write((self.ui.txt_SendMessage.text() + "\r").encode('utf-8')) # �N�r�Ŧ�ƾڸѽX���r�`
            
          
