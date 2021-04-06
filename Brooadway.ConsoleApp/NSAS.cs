using System;

namespace Brooadway.ConsoleApp
{
    //non static and static theory explained through this class
    public class NSAS
    {
        public static int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public static void FunctionOne()
        {
            Console.WriteLine("Number One = > " + NumberOne);
        }

        public void FunctionTwo()
        {
            Console.WriteLine("Number One = > " + NumberOne);
            Console.WriteLine("Number Two = > " + NumberTwo);
        }
    }
}