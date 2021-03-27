using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brooadway.ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string result = "y";
            do
            {
                //Console.BackgroundColor = ConsoleColor.Cyan;
                //Console.Title = "Broadway 4:30";
                //Console.Write("Write called");
                //Console.ForegroundColor = ConsoleColor.Black;
                //Console.WriteLine("Writeline called");

                //EvenOddExample();

                //ResultCalculationExampleUsingIfElse();

                //WeekDaysExample();

                TableGenerate();


                Console.WriteLine("Want to try more (y/n)?");
                result = Console.ReadLine();

            } while (result=="y" || result=="Y");

            Console.ReadLine();
        }

        static void TypeConversion()
        {
            //implicit conversion
            int i = 10;
            double j = i;


            //explicit conversion
            double x = 20.09;
            int y = (int)x;


            //Type Conversion Method
            double p = 21.20;
            int q = Convert.ToInt32(p);
        }

        static void ArithmeticOperatorsExample()
        {
            int i = 10;
            int j = 20;
            var k = i + j;
            var l = i - j;
            var m = i * j;
            var n = i / j;



            var x =1;
            var y = "test";
            var z = 'c';

            x = 20;

            object a = 1;
            object b = "object";
            object c = 'a';

            a = "";

            var p = (x == 3) && (y=="test");


        }

        static void IfElseExample()
        {
            var x = 0;
            var y = 1;
            if (x==0)
            {
                Console.WriteLine("X is 0");
            }
            else
            {
                Console.WriteLine("x is not 0");
            }
        }

        static void EvenOddExample()
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number/2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }


        static void ResultCalculationExampleUsingIfElse()
        {
            Console.WriteLine("Enter the percentage");
            var input = Console.ReadLine();
            var percentage = Convert.ToDouble(input);

            if (percentage>100 || percentage<0)
            {
                Console.WriteLine("Invalid percentage");
            }
            else if (percentage>80)
            {
                Console.WriteLine("Distinction");
            }
            else if (percentage>60)
            {
                Console.WriteLine("First Division");
            }
            else if (percentage>45)
            {
                Console.WriteLine("Second Division");
            }
            else if (percentage>32)
            {
                Console.WriteLine("Third Division");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }

        static void WeekDaysExample()
        {
            Console.WriteLine("Enter the DayofWeek");
            var input = Console.ReadLine();
            var dayOfWeek = Convert.ToInt32(input);

            Console.WriteLine("Using Switch Case");
            switch (dayOfWeek)
            {
                case 1:
                case 7:
                    Console.WriteLine("Its Weekend");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Its Weekdays");
                    break;
                default:
                    Console.WriteLine("Invalid days");
                    break;
            }


            Console.WriteLine("Using If Else");

            if (dayOfWeek==1 || dayOfWeek==7)
            {
                Console.WriteLine("Its weekend");
            }
            else if (dayOfWeek==2 || dayOfWeek==3 || dayOfWeek==4 || dayOfWeek==5 || dayOfWeek==6)
            {
                Console.WriteLine("Its weekdays");
            }
            else
            {
                Console.WriteLine("Invalid days");
            }
        }

        static void TableGenerate()
        {
            Console.WriteLine("Enter the Number of which you want to generate the table");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number+" x "+i+" = "+(number*i));
            }

        }
    }

    

   
}

