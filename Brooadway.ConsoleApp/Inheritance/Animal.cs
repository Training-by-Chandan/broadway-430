using System;

namespace Brooadway.ConsoleApp.Inheritance
{
    public class Animal
    {
        public Animal()
        {
            Name = "Default Name";
        }

        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }

        protected void ProtectedFunction()
        {
        }
    }

    public class Mammals : Animal
    {
        public Mammals() : base("Mammals Name")
        {
        }

        public Mammals(string name) : base(name)
        {
        }

        private void MammalFunction()
        {
            Name = "";
            Walk();
            ProtectedFunction();
        }
    }
}