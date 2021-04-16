using System;
using System.Runtime.Serialization;

namespace Brooadway.ConsoleApp.CustomStack
{
    public class StackType1 //container is fixed
    {
        private readonly int[] _container;
        private readonly int maxItems;
        private int index = -1; //0-4

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

    public class StackTypeString //container is fixed
    {
        private readonly string[] _container;
        private readonly int maxItems;
        private int index = -1; //0-4

        public StackTypeString()
        {
            maxItems = 5;
            _container = new string[maxItems];
        }

        public StackTypeString(int MaxItems)
        {
            maxItems = MaxItems;
            _container = new string[maxItems];
        }

        public int Counter => index + 1; //1-5 , 0 => no element


        public void Push(string item)
        {
            if (Counter < _container.Length)
            {
                index++;
                _container[index] = item;
            }
        }

        public string Pop()
        {
            if (Counter > 0)
            {
                var retVal = _container[index];
                _container[index] = "";
                index--;
                return retVal;
            }

            return "";
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


    public class StackTypeGeneric<T> //container is fixed
    {
        private readonly T[] _container;
        private readonly int maxItems;
        private int index = -1; //0-4

        public StackTypeGeneric()
        {
            maxItems = 5;
            _container = new T[maxItems];
        }

        public StackTypeGeneric(int MaxItems)
        {
            maxItems = MaxItems;
            _container = new T[maxItems];
        }

        public int Counter => index + 1; //1-5 , 0 => no element


        public void Push(T item)
        {
            if (Counter < _container.Length)
            {
                index++;
                _container[index] = item;
            }
        }

        public T Pop()
        {
            var retVal = _container[index];
            if (Counter > 0) index--;
            return retVal;
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


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface ILivinThing
    {
    }

    public interface IAnimal : ILivinThing
    {
    }

    public class Dog : IAnimal
    {
    }

    public class Cat : IAnimal
    {
    }


    public class Horse
    {
    }

    public interface IPlant : ILivinThing
    {
    }

    public class Rose : IPlant
    {
    }

    public class LivingThingStack<T1> where T1 : class
    {
    }

    public class LivingThingStack<T1, T2> where T1 : class
        where T2 : IPlant
    {
    }


    public class FunctionTemplating
    {
        public static bool Equals<T>(T item1, T item2)
        {
            return item1.ToString() == item2.ToString();
        }

        public static void SomeFunction<T1, T2>(T1 item1, T1 item2, T2 item3) where T1 : IAnimal where T2 : ILivinThing
        {
        }
    }


    public class SomeClass
    {
        public static void Function1(int i)
        {
            if (i == 0)
                throw new CustomException("Custom Exception : i cannot be 0");
            if (i == 5)
                throw new Exception("Exception Class : i cannot be 5");
            Console.WriteLine("Everything is good");
        }
    }

    [Serializable]
    public class CustomException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CustomException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}