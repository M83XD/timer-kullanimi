using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        int deger = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            deger++;
            label1.Text = deger.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            deger = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
                timer1.Interval += 100;
            else
                timer1.Interval = 3000;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100 )
                timer1.Interval -= 100;
            else
                timer1.Interval = 50;
        }
        int st = 0, dk = 58, sn = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sn <= 59)
            {
                sn++;
                label4.Text = sn.ToString();
            }
            else
            {
                sn = 0;
                dk += 1;
                label3.Text = dk.ToString();
            }
            if (dk > 59)
            {
                dk = 0;
                st += 1;
                label4.Text = st.ToString();
                label3.Text = dk.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Interval = 50;
            timer2.Enabled = true;
            timer2.Start();
        }
    }
}
