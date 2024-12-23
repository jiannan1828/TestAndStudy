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

namespace NeedleManual
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

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
    }
}
