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
    # 從表單取得 RadioButton 的選項
    selected_option = request.form.get("RadioButtonSelectedOption")
    # 更新模型
    _indexModel["RadioButtonSelectedOption"] = selected_option
    _indexModel["RichTextboxValue"] += "你選擇的 RadioButton 的選項是：" + selected_option + "\n"
    # 回傳 Index 頁面，同時傳入模型
    return render_template("index.html", index_model=_indexModel)
