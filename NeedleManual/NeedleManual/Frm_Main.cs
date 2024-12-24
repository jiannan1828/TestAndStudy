using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NeedleManual
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            Initialize_grp_位置與IO_ChildControlChanged_Listener(grp_位置與IO);
        }

        private void Frm_Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen pen = new Pen(Color.Black, 2))
            {
                pen.CustomEndCap = new AdjustableArrowCap(5, 5); // 箭頭大小

                // 繪製直角折線箭頭
                Point[] points = {
                    new Point(50, 50),  // 起點
                    new Point(50, 100), // 垂直下移
                    new Point(150, 100) // 水平右移
                };

                g.DrawLines(pen, points);
            }
        }
        private void grp_位置按鍵判斷(object sender, KeyPressEventArgs e)
        {
            // 如果按下的键不是数字或删除键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // 取消事件，阻止非数字输入
                e.Handled = true;
            }
        }

        private void grp_IO按鍵判斷(object sender, KeyPressEventArgs e)
        {
            // 只允许按下 '0' 或 '1' 或删除键
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
            {
                // 取消事件，阻止非 '0' 和 '1' 输入
                e.Handled = true;
            }
        }
    }
}
