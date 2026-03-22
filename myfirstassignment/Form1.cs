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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic4_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click_1(object sender, EventArgs e)
        {
            //Label labelnew = sender as Label;
            //string labelname = labelnew.Name;
            //if (labelnew == null) return;
            //string indexstring = labelname.Substring(5);

            //int labelindex = int.TryParse(indexstring, out  int index1) ? index1 : 0;
            //string labeln = $"label{labelindex}";
            //Label label = this.Controls.Find(labeln,true).FirstOrDefault() as Label;
            //int labelvalue = string.IsNullOrWhiteSpace(label.Text) ? 0 : Convert.ToInt32(label.Text);
        }
    }
}
