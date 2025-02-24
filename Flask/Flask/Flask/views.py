"""
Routes and views for the flask application.
"""
from datetime import datetime
from flask import render_template
from flask import request
from flask import session
import os
from Flask import app

@app.route('/')
@app.route('/home')
def home():
    """Renders the home page."""
    return render_template(
        'index.html',
        title='Home Page',
        year=datetime.now().year,
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
