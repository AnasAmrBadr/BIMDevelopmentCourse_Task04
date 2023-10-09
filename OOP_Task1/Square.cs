using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1
{
    internal class Square : Shape
    {
        public double Width { get; set; }

        public Square(string name, int id, Opacity opacity, Color color, double width) : base (name, id, opacity, color)
        {
            Width = width;            
        }
        public override double CalculateArea()
        {
            return Width * Width;
        }


    }
}
