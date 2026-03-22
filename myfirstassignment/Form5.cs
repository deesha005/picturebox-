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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //first();
            //second();
            // pyramid_problem();
            third();
        }
        private void first()
        {
            //Console.WriteLine("hello, i am first");
            //Console.ReadLine();
        }
        private void second()
        {
            //Console.WriteLine("hello, i am second");
            //Console.ReadLine();
            /*
                        for (int i = 2; i <= 3; i++)
                        {
                            for (int j =i; j <=i; j++)
                        {
                                Console.Write(" ");
                                Console.Write(i);

                        }

                        }*/
            ////////////
            //for (int i = 1; i <= 4; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);

            //        Console.Write(" ");
            //    }

            //    Console.WriteLine();

            //}

            //////////////********use of two for loops inside a loop******
            //int k = 1;
            //for (int i =1; i< 10;i++)
            //{
            //    for (int j = 1; j <= k; j++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    for (int j = 1; j <= 2; j++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 4; i <= 6; i++)
            //{
            //    for (int j = i; j <= i; j++)
            //    {
            //        Console.Write(i);

            //        Console.Write(" ");
            //    }
            //}


        }

        private void pyramid_problem()
        {
            /*        for (int i = 1; i <= 4; i++)
                    {
                       // Console.WriteLine("*");
                        for (int j = 1; j <= i; j++)
                    { 
                        Console.Write("*");
                    }
                        Console.Write('\n');
                    }*/


            /*  for (int i = 1; i <=4; i++) 
              {
                  //Console.WriteLine(i);
                  for (int j = 1; j <= i; j++)
                  { 
                      Console.Write(j);

                  }
                  Console.Write('\n');

              }*/

            /* for (int i = 1; i <=4; i++) 
                 {
                   //Console.WriteLine(i);
                     for (int j = 1; j <=i; j++) 
                     {
                         Console.Write(i);
                     }
                     Console.Write('\n');
                 }*/


            /*  int k = 1;
              for (int i = 1; i <= 4; i++)
              {
                 // Console.WriteLine(i);
                  for (int j = 1; j <=i; j++)
                  {
                   Console.Write(k++);

                  }
                  Console.Write('\n');
              }*/

            //int k ;
            //int l=2 ;

            //for (int i = 1; i <= 1; i++)
            //{
            //    for (k = 1; k<=1; k++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= i+1; j++)
            //    {
            //        Console.Write(i);
            //    }   
            //    Console.WriteLine();

            //}

            //for (int i=2;i<=3;i++)
            //{//i=2
            // //for (int j=i;j<=i;j++)
            // //{
            //    Console.Write(" ");
            //    //}
            //    Console.Write(i);
            //}//_2_3
            //     //i=3 
        }
        private void third()
        {
            //string[] car = { "BMW", "audi", "volvo" };

            //Console.WriteLine(car[2]);

            //foreach (string s in car) 
            //  { 
            //    Console.WriteLine(s);
            //}


            /*int a = 0;

            string[] args ={ "bmw", "volvo", "tata" };

            // args = new string[]{"bmw","volvo","tata"};
            for (int i = 0; i < args.Length; i++) 
            
            {
                Console.WriteLine(args[i]);
            
            }*/

            /////////pyramid prblm (triangle no incremented by one)
            //int num = 1;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 4 - i; j++)

            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num+ " ");
            //        num++;
            //    }
            //    Console.WriteLine();
            //}
            //int num1 = 11;
            //for (int i=4;i>=1;i--)
            //{

            //    for (int j = 1; j <= 4 - i; j++)

            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num1+ " ");
            //        num1++;
            //    }
            //    Console.WriteLine();
            //}


            ////////triangle astrik 
            /*  for (int i=1;i<=4;i++) 
              {
                  for (int j = 1; j <= 4 - i; j++)
                  {
                      Console.Write(" ");
                  }
                  for (int j = 1; j<=i; j++)
                  {
                      Console.Write("*"+" ");

                  }
                  Console.WriteLine();

              }*/
            /*  int num = 1;
              for (int i = 1; i <=4; i++) 
              {
                  for (int j =1; j <=4-i;j++) 

                  {
                      Console.Write(" ");
                  }
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write(i+" ");

                  }
                  Console.WriteLine();
              }
  */
            /*int i = 1;
            for ( i = 1;i <=5;i++)
            {
                for (int j = 1; j <=5-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=2*i-1; j++)
                {
                    Console.Write("*");
                    
                }
                    Console.WriteLine();
                }

            }*/

           
            
            //arr[0] = input;

            //Console.WriteLine(arr);
            
            







        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter the 10 elements in array:");
            for (int i=1;i<=arr.Length;i++)
            {
                arr[i]=Convert.ToInt32(textBox1.Text);
            }
                Console.WriteLine(arr);
        }*/































    }
}
    

