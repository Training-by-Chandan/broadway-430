using System;

namespace Brooadway.ConsoleApp.Abstract
{
    public abstract class DrawingAbstract
    {
        public abstract double Area();
        public abstract void TakeInput();

        public void Display()
        {
            Console.WriteLine("Display called from Drawing abstract class");
        }
    }

    public class CircleAbs : DrawingAbstract
    {
        public double _radius;

        public override double Area()
        {
            return 3.14 * _radius * _radius;
        }

        public override void TakeInput()
        {
            Console.WriteLine("Enter Radius");
            _radius = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class SquareAbs : DrawingAbstract
    {
        private double _length;

        public override double Area()
        {
            return Math.Pow(_length, 2);
        }


        public override void TakeInput()
        {
            Console.WriteLine("Enter Lenght");
            _length = Convert.ToDouble(Console.ReadLine());
        }
    }
}