using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Modbus.Device;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 每1000毫秒觸發一次 (1秒)
            timer2.Interval = 1000;
            timer1.Start();
            label4.Text = "00:00:00";

        }

        double num1;
        double num2;
        Double num3;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out num1);

            if (num1 > 15)

            {
                label1.Text = "大於15";
                label1.ForeColor = Color.Red;


            }
            else if (num1 > 10)
            {
                label1.Text = "大於10";
            }
            else if (num1 > 5)
            {
                label1.Text = "大於五";
            }
            else
            {
                label1.Text = "大於";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out num2);
            switch (num2) 
            {
                case 1:

                    label2.Text = "大於15";
                    break;

                case 2:
                    label2.Text = "大於10";
                    break;

                case 3:
                    label2.Text = "大於5";
                    break;

                default:
                    label2.Text = "大於";
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        int sec ;
        int min ;
        int hour;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sec++; // 每秒 +1
            label4.Text = $"{hour:D2}:{min:D2}:{sec:D2} ";
            if (sec >=60)
            {
                min++;
                sec = 00;
            }
            if (min >= 60)
            {
                hour++;
                min = 00;
                sec = 00;
            }
        }

        private void STAR_Click(object sender, EventArgs e)
        {
            sec = 0;
            min = 0;
            hour = 0;
            timer2.Start();
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out double num3);
           
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "123hahahaha";
        }
    }
}
