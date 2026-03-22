using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace myfirstassignment
{
    public partial class Form9 : Form
    {
        TimeSpan time = new TimeSpan(0);
        bool timerRunning = false;
        public Form9()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 second
            lblTime.Text = "00:00:00";
            
        } 

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            time = time.Add(TimeSpan.FromSeconds(1));
            lblTime.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                timer1.Start();
                timerRunning = true;
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerRunning = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time = new TimeSpan(0);
            lblTime.Text = "00:00:00";
            timerRunning = false;
        }
    }
}
