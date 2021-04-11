using System;
using Broadway;
using Brooadway.ConsoleApp.Inheritance;
using interfaces = Brooadway.ConsoleApp.Interface;

namespace Brooadway.ConsoleApp
{
    internal class Program
    {
        public Human human = new Human();

        private static void Main(string[] args)
        {
            var result = "y";
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

                //TableGenerate();

                //StudentExample();

                //ConstructorOverloadingExample();

                //StaticAndNonStaticExample();

                //this function contains code where inheritance is properly explained
                //InheritanceExample();


                //OperatorOverloadingExample();

                //PolymorphismExample();

                FactoryInterfaceExample();

                Console.WriteLine("Want to try more (y/n)?");
                result = Console.ReadLine();
            } while (result == "y" || result == "Y");

            Console.ReadLine();
        }


        public static void FactoryInterfaceExample()
        {
            Console.WriteLine("1. Circle\n2. Square\n3. Rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());
            interfaces.IDrawing drawingObj;

            switch (choice)
            {
                case 1:
                    drawingObj = new interfaces.Cirle();
                    break;
                case 2:
                    drawingObj = new interfaces.Square();
                    break;
                case 3:
                    drawingObj = new interfaces.Rectangle();
                    break;
                default:
                    return;
                    break;
            }

            drawingObj.TakeInput();
            Console.WriteLine("Area = >" + drawingObj.Area());
            Console.WriteLine("Perimeter = >" + drawingObj.Perimeter());
        }

        public static void InterfaceExplained()
        {
            var squareObj = new interfaces.Square();
            interfaces.IArea areaInt = squareObj;

            var circleObj = new interfaces.Cirle();
            //circleObj.Add();
            areaInt = circleObj;


            interfaces.IPerimeter perimeterInt = circleObj;
            perimeterInt = squareObj;

            interfaces.IDrawing drawingInt = squareObj;
        }

        private static void PolymorphismExample()
        {
            Drawing circle = new Circle();

            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();

            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());
        }


        private static void OperatorOverloadingExample()
        {
            var a1 = new Animal();
            a1.Name = "Dog";
            a1.LastName = "Gates";
            var a2 = new Animal();
            a2.Name = "Cat";
            a2.LastName = "Gates";
            var str = a1 + a2;

            Console.WriteLine("final firstname => " + str.Name);
            Console.WriteLine("final lastname => " + str.LastName);

            if (a1 == a2) Console.WriteLine("both are equal");
            else Console.WriteLine("Both are not equal");
        }


        private static void InheritanceExample()
        {
            var animal = new Animal();
            var name = animal.Name;
            var AnimalTwo = new Animal("HOmo Sapiens");

            var mammals = new Mammals();
            Console.WriteLine(mammals.Name);
        }

        private static void TypeConversion()
        {
            //implicit conversion
            var i = 10;
            double j = i;


            //explicit conversion
            var x = 20.09;
            var y = (int) x;


            //Type Conversion Method
            var p = 21.20;
            var q = Convert.ToInt32(p);
        }

        private static void ArithmeticOperatorsExample()
        {
            var i = 10;
            var j = 20;
            var k = i + j;
            var l = i - j;
            var m = i * j;
            var n = i / j;


            var x = 1;
            var y = "test";
            var z = 'c';

            x = 20;

            object a = 1;
            object b = "object";
            object c = 'a';

            a = "";

            var p = x == 3 && y == "test";
        }

        private static void IfElseExample()
        {
            var x = 0;
            var y = 1;
            if (x == 0)
                Console.WriteLine("X is 0");
            else
                Console.WriteLine("x is not 0");
        }

        private static void EvenOddExample()
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number / 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is Odd");
        }


        private static void ResultCalculationExampleUsingIfElse()
        {
            Console.WriteLine("Enter the percentage");
            var input = Console.ReadLine();
            var percentage = Convert.ToDouble(input);

            if (percentage > 100 || percentage < 0)
                Console.WriteLine("Invalid percentage");
            else if (percentage > 80)
                Console.WriteLine("Distinction");
            else if (percentage > 60)
                Console.WriteLine("First Division");
            else if (percentage > 45)
                Console.WriteLine("Second Division");
            else if (percentage > 32)
                Console.WriteLine("Third Division");
            else
                Console.WriteLine("Fail");
        }

        private static void WeekDaysExample()
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

            if (dayOfWeek == 1 || dayOfWeek == 7)
                Console.WriteLine("Its weekend");
            else if (dayOfWeek == 2 || dayOfWeek == 3 || dayOfWeek == 4 || dayOfWeek == 5 || dayOfWeek == 6)
                Console.WriteLine("Its weekdays");
            else
                Console.WriteLine("Invalid days");
        }

        private static void TableGenerate()
        {
            Console.WriteLine("Enter the Number of which you want to generate the table");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            for (var i = 1; i <= 10; i++) Console.WriteLine(number + " x " + i + " = " + number * i);
        }

        /// <summary>
        ///     We have implemented the properties and variable stuffs
        /// </summary>
        private static void StudentExample()
        {
            Console.WriteLine("Student s1");
            var s1 = new StudentExams();
            s1.EnglishMarks = 21;
            s1.MathMarks = 30;
            Console.WriteLine("Total => " + s1.TotalMarks);
            Console.WriteLine("Percentage => " + s1.Percentage);
            Console.WriteLine("Division => " + s1.Division);


            Console.WriteLine("Student s2");
            var s2 = new StudentExams();
            s2.EnglishMarks = 19;
            s2.MathMarks = 3;
            Console.WriteLine("Total => " + s2.TotalMarks);
            Console.WriteLine("Percentage => " + s2.Percentage);
            Console.WriteLine("Division => " + s2.Division);

            s1.Display();
        }

        private static void ConstructorOverloadingExample()
        {
            var h1 = new Human();
            var h3 = new Human();
            var h2 = new Human("Amit");

            //h1.DisplayName();
            //h2.DisplayName();


            h1.IncreaseJby1(); // this will be 11
            h1.ValueOfJ();
            h2.IncreaseJby1(); //12
            h2.ValueOfJ();
            h3.IncreaseJby1(); //13
            h3.ValueOfJ();
            h3.DisplayName();
        }

        private static void SubClassExample()
        {
            var newclass = new Human.NewClass();
        }

        private static void StaticAndNonStaticExample()
        {
            NSAS.NumberOne = 50;
            var objA = new NSAS();
            objA.NumberTwo = 100;
            objA.FunctionTwo();

            //NSAS.NumberOne = 20;
            var objB = new NSAS();
            objB.NumberTwo = 200;
            objB.FunctionTwo();

            //var numberOne=NSAS.NumberOne;
            //NSAS.FunctionOne();
        }
    }
}