using System;

namespace Brooadway.ConsoleApp.CustomStack
{
    public class StackType1 //container is fixed
    {
        private readonly int[] _container;
        private int index = -1; //0-4
        private readonly int maxItems;

        public StackType1()
        {
            maxItems = 5;
            _container = new int[maxItems];
        }

        public StackType1(int MaxItems)
        {
            maxItems = MaxItems;
            _container = new int[maxItems];
        }

        public int Counter => index + 1; //1-5 , 0 => no element


        public void Push(int item)
        {
            if (Counter < _container.Length)
            {
                index++;
                _container[index] = item;
            }
        }

        public int Pop()
        {
            if (Counter > 0)
            {
                var retVal = _container[index];
                _container[index] = 0;
                index--;
                return retVal;
            }

            return 0;
        }

        public void Display()
        {
            Console.WriteLine("Total Items => " + Counter);
            //var temp = new int[Counter];
            //for (var i = 0; i < Counter; i++) temp[i] = _container[i];

            var temp = _container;
            Array.Resize(ref temp, Counter);

            //Array.Reverse(temp);
            foreach (var item in temp) Console.WriteLine(item);
        }
    }
}