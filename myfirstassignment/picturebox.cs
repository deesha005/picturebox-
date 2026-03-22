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
    public partial class picturebox : Form
    {
        public picturebox()
        {
            InitializeComponent();

            pictureBox1.Click += DisplaypictureBox_Click;
            pictureBox2.Click += DisplaypictureBox_Click;
            pictureBox3.Click += DisplaypictureBox_Click;
            pictureBox4.Click += DisplaypictureBox_Click;
            pictureBox5.Click += DisplaypictureBox_Click;
            pictureBox6.Click += DisplaypictureBox_Click;

            DisplaypictureBox.SizeMode=PictureBoxSizeMode.Zoom;
        }

      

      

        private void DisplaypictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedbox = sender as PictureBox;
            if (clickedbox != null && clickedbox.Image != null)
            { 
                DisplaypictureBox.Image=clickedbox.Image;

            }
        }
        }
    }

