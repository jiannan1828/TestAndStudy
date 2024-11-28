using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training4
{
    public partial class frm_Change3 : Form
    {
        public frm_Change3()
        {
            InitializeComponent();

            btn_OK.DialogResult = DialogResult.OK;
            btn_Cancel.DialogResult = DialogResult.Cancel;
        }
        public string txtChange3Text // 運用 get set 去訪問表單私有屬性
        {
            get { return txt_Change3.Text; }  
            set { txt_Change3.Text = value; } 
        }
    }
}
