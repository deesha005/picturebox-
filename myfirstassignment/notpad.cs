using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Needed for File.ReadAllText and File.WriteAllText


namespace myfirstassignment
{
    public partial class notpad : Form
    {
        public notpad()
        {
            InitializeComponent();
        }



            

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void btnyes_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem1_Click(sender, e);
            textBox1.Clear(); 
            panel1.Visible = false;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.Visible = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           
        }
    }
}
