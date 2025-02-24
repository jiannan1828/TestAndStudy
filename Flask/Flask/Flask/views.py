"""
Routes and views for the flask application.
"""

from datetime import datetime
from flask import render_template
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

@app.route('/radio_button_submit', methods=['POST'])
def radio_button_submit():
    # �q�����o RadioButton ���ﶵ
    selected_option = request.form.get("RadioButtonSelectedOption")
    # ��s�ҫ�
    _indexModel["RadioButtonSelectedOption"] = selected_option
    _indexModel["RichTextboxValue"] += "�A��ܪ� RadioButton ���ﶵ�O�G" + selected_option + "\n"
    # �^�� Index �����A�P�ɶǤJ�ҫ�
    return render_template("index.html", index_model=_indexModel)
