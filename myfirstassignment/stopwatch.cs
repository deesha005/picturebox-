using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstassignment
{
    public partial class stopwatch : Form
    {
        TimeSpan time=TimeSpan.Zero;
        bool timerrunning = false;
        public stopwatch()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            labeltime.Text = "00:00:00";

        }

        private void stopwatch_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(TimeSpan.FromSeconds(1));
            labeltime.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timerrunning) 
            {
                timer1.Start();
                timerrunning=true; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
             timerrunning = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time = new TimeSpan(0);
            labeltime.Text = "00:00:00";
            timerrunning = false;

        }
    }
}
