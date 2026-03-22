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
    public partial class animation : Form
    {
        public animation()
        {
            InitializeComponent();

            pctbox1.Click += displaypctbox_Click;
            pctbox2.Click += displaypctbox_Click;
            pctBox3.Click += displaypctbox_Click;
            pctBox4.Click += displaypctbox_Click;
            pctBox5.Click += displaypctbox_Click;
            pctBox6.Click += displaypctbox_Click;


            displaypctbox.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void displaypctbox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;

            if (clickedBox != null && clickedBox.Image != null)
            {
                displaypctbox.Image = clickedBox.Image;
            
            }
        }
    }
}

        
