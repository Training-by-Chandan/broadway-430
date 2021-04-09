using System;

namespace Brooadway.ConsoleApp
{
    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }

        public double Circumference()
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public Circle()
        {
            Radius = 5;
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }

        public double Circumference()
        {
            return 0;
        }
    }

    public class Square : Drawing
    {
        public Square()
        {
            Length = 6;
        }

        public double Length { get; set; }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public Rectangle()
        {
            Height = 5.3;
            Width = 3.4;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }
}