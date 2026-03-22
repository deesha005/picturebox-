using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstassignment
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string divya;
            divya = "hello world!";
            Console.WriteLine(divya);*/


            //Console.WriteLine("Enter the value of x:");
            //string x;
            //x = Convert.ToString(Console.WriteLine());
            //Console.ReadLine();

            //Console.WriteLine("hello"+x);





            //int x, y, z, w, p, q;
            // string sum;
            // sum = textBox1.Text;
            // Console.WriteLine("your name is: "+sum);
            // //x = Convert.ToInt32(textBox1.Text);
            //// Console.WriteLine(x);
            // Console.ReadLine();
            //Console.WriteLine("enter the value of y:");
            //y = Convert.ToInt32(textBox2.Text);
            //Console.WriteLine(y);
            //Console.ReadLine();
            //Console.WriteLine("enter the value of z:");
            //z = Convert.ToInt32(textBox3.Text);
            //Console.WriteLine(z);   
            //Console.ReadLine();
            //Console.WriteLine("enter the value of w:");
            //w = Convert.ToInt32(textBox4.Text);
            //Console.WriteLine(w);
            //Console.ReadLine();
            //Console.WriteLine("enter the value of p:");
            //p = Convert.ToInt32(textBox5.Text);
            //Console.WriteLine(p);
            //Console.ReadLine();
            //int q; 
            //Console.WriteLine("enter the value of q:");
            //q = Convert.ToInt32(textBox6.Text);
            //Console.WriteLine(q);
            //Console.ReadLine();
            //sum=x+y+z+w+p+q;
            //Console.WriteLine(sum);
            //Console.ReadLine();

            // string a = "Hello World!";

            //// declare string variable named frnd and assigned vaules
            //string frnd = "Sudipto Chatterjee ";

            ///// frnd.IndexOf("C");
            /////frnd is string
            /////indexOf("C") is for finding the index of C
            /////storing the value of index of c in integer var of name 'n' 
            /////
            //Console.WriteLine(frnd.IndexOf("C"));
            //int n=frnd.IndexOf("C");
            //Console.WriteLine(n);
            ////in substring index is starting from 1 
            //Console.WriteLine(frnd.Substring(n));



            //////////////////////////////////////////////////////////////
            //string card = "Rashmi Sudipto Chatterjee";
            //Console.WriteLine(card.Substring(7));

            //int a = 5; int b = 10;

            //if (a == b)
            //{
            //    Console.WriteLine("a is greater");//false
            //}
            //else
            //{
            //    Console.WriteLine("b is greater");
            //}


            //?:

            //Console.WriteLine((a>b)?"a is greater":"b is greater");

            // if else
            //else if
            //else
            //
            //testnary operator
            //
            //int l, k,m,n;
            //l = 50;
            //k = 12;
            //m = 23;
            //n = 34;

            ////  string time = DateTime.Now.ToString("HH:mm");
            //Console.WriteLine((k>l) ? "k is greater":"k is small");
            //Console.WriteLine((m<n) ? "true":"false");

            //int day = 5;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Looking foreward for holiday");
            //        break;
            //}

            //write  -- specific space or require
            //writeline -- full  space

            //////////Nested loop
            ///square
            // int a = 5;
            //// int b = 2;
            // for (int i = 1; i <=a ; i++)
            // {
            //     for (int j = 1; j<=a-3; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine("");
            // }


            string[] now = { "array", "string", "int", "char", "bool" };
            foreach (string i in now)
            { 
                Console.WriteLine(i);
            }

                

            int[] then = { 1, 2, 3, 4, 5, 6 };
            foreach (int a in then)
                { Console.WriteLine(a); }

            //Console.WriteLine(now[0]);
            //Console.WriteLine(then[0]);
           /* Console.WriteLine(then[2]);
            Console.WriteLine(then[3]);*/


            //string a = "Bapuji";
            //Console.WriteLine(a[5]);
            //Console.WriteLine(a.IndexOf("B"));
        }
    }
   
    }

