using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 2] print using forloop 1,3,5 till 11




            //for (int i = 1; i <= 11; i += 2)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();





            // 3] print *




            //Console.WriteLine("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }

            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();




            //// 4]  sum of 1st natural numbers




            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum = sum + i;


            //}
            //Console.WriteLine("The sum of 5 natural numbers is" + sum);
            //Console.ReadLine();




            //  5]  print the pattern

            //Console.WriteLine("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.WriteLine("*");
            //    }

            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();


            //  6]  print 10 20 ....190 continue

            //for (int i = 10; i <= 190; i += 20)
            //{
            //    if (i == 100)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}
            //    Console.ReadLine();



            // 7]  print 10 20 ....190 break



            //for (int i = 10; i <= 190; i += 20)
            //{
            //    if (i == 100)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();



            //  8]  print odd or even using switch


            //Console.WriteLine("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //switch (n % 2)
            //{
            //    case 0: 
            //        Console.WriteLine($"{n} is even.");
            //        break;
            //    case 1: 
            //        Console.WriteLine($"{n} is odd.");
            //        break;
            //    default: 
            //        Console.WriteLine("Unexpected value.");
            //        break;
            //}


            //Console.ReadLine();


            // 9 ]  find error

            int[] n = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadLine();





        }
    }
}
