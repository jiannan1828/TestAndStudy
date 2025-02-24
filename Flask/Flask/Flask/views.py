"""
Routes and views for the flask application.
"""
import serial   
import serial.tools.list_ports
import threading

from datetime import datetime
from flask import render_template
from flask import request
from flask import session
import os
from Flask import app

ser = serial.Serial()

@app.route('/')
@app.route('/home')
def home():
    cmb_Port_Items = [port.device for port in serial.tools.list_ports.comports()]
    session["cmb_Port_Items"] = cmb_Port_Items

    return render_template('index.html',
        cmb_Port_Items = cmb_Port_Items,
        cmb_Port_Enabled = True,
        btn_Connect_Enabled = True,
        btn_Disconnect_Enabled = False,
        btn_SendMessage_Enabled = False
    )

@app.route('/RadioButtonSubmit', methods=['POST'])
def RadioButtonSubmit():
    RadioButtonSelectedOption = request.form.get("RadioButtonSelectedOption", "")
    
    current_text = session.get("RichTextboxValue", "")
    
    current_text += "RadioButton is : " + RadioButtonSelectedOption + os.linesep
    
    session["RichTextboxValue"] = current_text

    RichTextboxValue = current_text

    return render_template("index.html", RichTextboxValue = RichTextboxValue)

@app.route('/CheckboxSubmit', methods=['POST'])
def CheckboxSubmit():
    CheckboxSelectedOptions = request.form.getlist("CheckboxSelectedOptions")
    
    current_text = session.get("RichTextboxValue", "")
    
    current_text += "Checkbox is : " + ", ".join(CheckboxSelectedOptions) + os.linesep
    
    session["RichTextboxValue"] = current_text

    RichTextboxValue = current_text

    return render_template("index.html", RichTextboxValue = RichTextboxValue)

@app.route('/TextboxSubmit', methods=['POST'])
def TextboxSubmit():
    TextboxValue = request.form.get("TextboxValue")
    
    current_text = session.get("RichTextboxValue", "")
    
    current_text += "Textbox is : " + TextboxValue + os.linesep
    
    session["RichTextboxValue"] = current_text

    RichTextboxValue = current_text

    return render_template("index.html", RichTextboxValue = RichTextboxValue)

@app.route('/DropDownSubmit', methods=['POST'])
def DropDownSubmit():
    DropDownSelectedOption = request.form.get("DropDownSelectedOption")
    
    current_text = session.get("RichTextboxValue", "")
    
    current_text += "DropDown is : " + DropDownSelectedOption + os.linesep
    
    session["RichTextboxValue"] = current_text

    RichTextboxValue = current_text

    return render_template("index.html", RichTextboxValue = RichTextboxValue)

@app.route('/btn_Connect_Click', methods=['POST'])
def btn_Connect_Click():

    ser.port =  request.form.get("cmb_Port_Text")
    ser.baudrate = 9600
    ser.bytesize=serial.EIGHTBITS  
    ser.parity=serial.PARITY_NONE 
    ser.stopbits=serial.STOPBITS_ONE  
    ser.timeout = 1           

    ser.open()

    current_text = session.get("rtb_ReceiveMessage_Text")
    current_text += f"Port {request.form.get('cmb_Port_Text')} Open Successfully!\n"
    session["rtb_ReceiveMessage_Text"] = current_text
    session["cmb_Port_Text"] = request.form.get("cmb_Port_Text")
    session["cmb_Port_Enabled"] = False;
    session["btn_Connect_Enabled"] = False;
    session["btn_Disconnect_Enabled"] = True;
    session["btn_SendMessage_Enabled"] = True;

    data_Received_Listener = threading.Thread(target = data_Received_Handler) 
    data_Received_Listener.start()
    
    return render_template('index.html',
        rtb_ReceiveMessage_Text = session["rtb_ReceiveMessage_Text"],
        cmb_Port_Text = session["cmb_Port_Text"],
        cmb_Port_Items = session["cmb_Port_Items"],
        cmb_Port_Enabled = session["cmb_Port_Enabled"],
        btn_Connect_Enabled = session["btn_Connect_Enabled"],
        btn_Disconnect_Enabled = session["btn_Disconnect_Enabled"],
        btn_SendMessage_Enabled = session["btn_SendMessage_Enabled"],
        txt_SendMessage_Text = session["txt_SendMessage_Text"]
    )

@app.route('/btn_Disconnect_Click', methods=['POST'])
def btn_Disconnect_Click():
    ser.close()

    current_text = session.get("rtb_ReceiveMessage_Text")
    current_text += f"Port {request.form.get('cmb_Port_Text')} Close Successfully!\n"
    session["rtb_ReceiveMessage_Text"] = current_text
    session["cmb_Port_Enabled"] = True;
    session["btn_Connect_Enabled"] = True;
    session["btn_Disconnect_Enabled"] = False;
    session["btn_SendMessage_Enabled"] = False;

    return render_template('index.html',
        rtb_ReceiveMessage_Text = session["rtb_ReceiveMessage_Text"],
        cmb_Port_Text = session["cmb_Port_Text"],
        cmb_Port_Items = session["cmb_Port_Items"],
        cmb_Port_Enabled = session["cmb_Port_Enabled"],
        btn_Connect_Enabled = session["btn_Connect_Enabled"],
        btn_Disconnect_Enabled = session["btn_Disconnect_Enabled"],
        btn_SendMessage_Enabled = session["btn_SendMessage_Enabled"],
        txt_SendMessage_Text = session["txt_SendMessage_Text"]
    )

@app.route('/btn_SendMessage_Click', methods=['POST'])
def btn_SendMessage_Click():
    ser.write((request.form.get("txt_SendMessage_Text") + "\r").encode('utf-8'))
    session["txt_SendMessage_Text"] = request.form.get("txt_SendMessage_Text")

    current_text = session.get("rtb_ReceiveMessage_Text")
    current_text += f"Port {request.form.get('cmb_Port_Text')} Send Successfully!\n"
    session["rtb_ReceiveMessage_Text"] = current_text

    return render_template('index.html',
        rtb_ReceiveMessage_Text = session["rtb_ReceiveMessage_Text"],
        cmb_Port_Text = session["cmb_Port_Text"],
        cmb_Port_Items = session["cmb_Port_Items"],
        cmb_Port_Enabled = session["cmb_Port_Enabled"],
        btn_Connect_Enabled = session["btn_Connect_Enabled"],
        btn_Disconnect_Enabled = session["btn_Disconnect_Enabled"],
        btn_SendMessage_Enabled = session["btn_SendMessage_Enabled"],
        txt_SendMessage_Text = session["txt_SendMessage_Text"]
    )

def data_Received_Handler(self):

    received_data_buffer = b""  

    while self.ser.is_open:
        try:
            if self.ser.in_waiting > 0:
                received_data = self.ser.read(self.ser.in_waiting)  
                try:
                    received_data_buffer += received_data
                    decoded_data = received_data_buffer.decode('utf-8')  
                except UnicodeDecodeError:  
                    continue  
                if "\r" in decoded_data:  
                    self.ui.rtb_ReceiveMessage.append(decoded_data.rstrip()) 
                    received_data_buffer = b""
        except:
            break;