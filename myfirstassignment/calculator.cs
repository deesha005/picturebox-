using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstassignment
{
    public partial class calculator : Form
    {
        int a;
        int b;
        double firstnumber;
        double secondnumber;
        double result;
        string operation;

        public calculator()
        {
            InitializeComponent();
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = 1;
            textBox1.Text += a.ToString();
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = 2;
            textBox1.Text += a.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = 3;
            textBox1.Text += a.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = 4;
            textBox1.Text += a.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = 5;
            textBox1.Text += a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = 6;
            textBox1.Text += a.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = 7;
            textBox1.Text += a.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = 8;
            textBox1.Text += a.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = 9;
            textBox1.Text += a.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            firstnumber=Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = " 1/firstname";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstnumber =Convert.ToDouble(textBox1.Text);
            result = firstnumber * firstnumber;
            textBox1.Text = result.ToString();
            //textBox1.Clear();
            //operation = "square";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            firstnumber =Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(firstnumber);
            textBox1.Text = result.ToString();
            //textBox1.Clear();
            //operation = "sqRoot";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstnumber=Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = " / ";


        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstnumber= Convert.ToDouble(textBox1.Text);
            textBox1.Clear() ;
            operation = " * ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            firstnumber =Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = " - ";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = " + ";
            //secondnumber = Convert.ToDouble(textBox1.Text); 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = 0;
            textBox1.Text += a.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            firstnumber=Convert.ToDouble((string)textBox1.Text);
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""||textBox1.Text == null) { textBox1.Text = "0"; }
            double secondnumber = Convert.ToDouble(textBox1.Text);
            double result = 0;


            if (operation == " + ")
            {
                result = firstnumber + secondnumber;
                textBox1.Text = "Result: " + result.ToString();
            }
            else if (operation == " - ")
            {
                result = firstnumber - secondnumber;
                textBox1.Text = "Result: " + result.ToString();
            }

            else if (operation == " * ")
            {
                result = firstnumber * secondnumber;
                textBox1.Text = "Result: " + result.ToString();
            }

            else if (operation == " / ")
            {
                result = firstnumber / secondnumber;
                textBox1.Text = "Result: " + result.ToString();
            }
            else if (operation == "square")
            {
                result = firstnumber * firstnumber;
                textBox1.Text = "Result: " + result.ToString();
            }
            else if (operation == "sqRoot")
            {
                result = Math.Sqrt(firstnumber);
                textBox1.Text = "Result: " + result.ToString();
            }
            else if (operation == "1/firstname")
            {
                result = 1 / firstnumber;
                textBox1.Text= "Result: " + result.ToString();

            }
            else
            {
                MessageBox.Show("Please select your operations");
            }
        }

        }
    }
