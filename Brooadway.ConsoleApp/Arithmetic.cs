using System;

namespace Brooadway.ConsoleApp
{
    public class Arithmetic
    {
        //private int i = 10;

        public void Addby1(int i)
        {
            i++;
            Console.WriteLine("i => " + i);
        }

        public void Addby1Ref(ref int i)
        {
            i++;
            Console.WriteLine("i => " + i);
        }


        public string SomeFunction(int i, out int j)
        {
            j = i;
            return "Some String";
        }
    }
}