using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

            Button button = (Button)start;
            button.Text = "또 눌러??";
            printText.Text += "*";
            tb.Text += "*";

            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }

        }

        private int elapasedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapasedTime++;
            printText.Text = elapasedTime + "초 경과";
            tb.Text = elapasedTime + "초 경과";
            progressBar1.Value = elapasedTime;
        }
    }
}
