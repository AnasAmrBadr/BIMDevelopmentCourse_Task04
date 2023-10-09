using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1
{
    internal class Rectangle : Shape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public Rectangle(string name, int id, Opacity opacity, Color color, double length, double width) : base (name, id, opacity, color)
        {
            Lenght = length; 
            Width = width;
        }
        public override double CalculateArea()
        {
            return Lenght * Width;
        }



    }
}
