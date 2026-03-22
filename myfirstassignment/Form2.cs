using System.Windows.Forms;

using System;

namespace myfirstassignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ///const variable
            /* const int lab = 50;
             lab = 70;
             Console.WriteLine(lab);*/

            ///concatenation
            /* string k = "divya";
             string p = "shiv";

             Console.WriteLine(k+"\n"+p);*/

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // string Name, MiddleName, LastName, Email;
           // Name = text1.Text;
            //Console.WriteLine(Name);

            int x, y;
            int sum;
            x = Convert.ToInt32(text1.Text);
            y = Convert.ToInt32(text2.Text);
            sum = x * y;
            Console.WriteLine(sum);

           //label2.Text = text1.Text;

            //MiddleName = text2.Text;
            //Console.WriteLine(MiddleName);

            //LastName = text3.Text;
            //Console.WriteLine(LastName);

            //Email = text4.Text;
            //Console.WriteLine(Email);

            //int PhoneNumber;
            //PhoneNumber=Convert.ToInt32(text5.Text);
            //Console.WriteLine(PhoneNumber);

            //string Address;
            //Address=Convert.ToString(text6.Text);
            //Console.WriteLine(Address);
            
           

        }
    }
}
