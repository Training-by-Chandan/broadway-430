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

        public string LastName { get; set; }

        public string Name { get; set; }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }

        protected void ProtectedFunction()
        {
        }

        public static Animal operator +(Animal a1, Animal a2)
        {
            var sumName = a1.Name + " " + a2.Name;
            var sumLastName = a1.LastName + " " + a2.LastName;
            return new Animal {Name = sumName, LastName = sumLastName};
        }

        public static bool operator !=(Animal a1, Animal a2)
        {
            return a1.Name != a2.Name || a1.LastName != a2.LastName;
        }

        public static bool operator ==(Animal a1, Animal a2)
        {
            return a1.Name == a2.Name && a1.LastName == a2.LastName;
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