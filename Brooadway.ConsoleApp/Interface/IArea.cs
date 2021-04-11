using System;

namespace Brooadway.ConsoleApp.Interface
{
    public interface IArea
    {
        double Area();
    }

    public interface IPerimeter
    {
        double Perimeter();
    }

    public interface IDrawing : IArea, IPerimeter
    {
        void TakeInput();
    }

    public class Cirle : IDrawing
    {
        private double _radius;

        public double Area()
        {
            return 3.14 * _radius * _radius;
        }

        public double Perimeter()
        {
            return 2 * 3.14 * _radius;
        }

        public void TakeInput()
        {
            Console.WriteLine("Enter Radius");
            _radius = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Square : IDrawing
    {
        private double _length;

        public double Area()
        {
            return Math.Pow(_length, 2);
        }

        public double Perimeter()
        {
            return 4 * _length;
        }

        public void TakeInput()
        {
            Console.WriteLine("Enter Lenght");
            _length = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Rectangle : IDrawing
    {
        public double Area()
        {
            throw new NotImplementedException();
        }

        public double Perimeter()
        {
            throw new NotImplementedException();
        }

        public void TakeInput()
        {
            throw new NotImplementedException();
        }
    }
}