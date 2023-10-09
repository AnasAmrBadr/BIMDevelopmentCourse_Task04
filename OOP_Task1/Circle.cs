using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1
{
    internal class Circle : Shape
    {
        public double Diameter { get; set; }
        public double Pi { get; }
        public Circle (string name, int id, Opacity opacity, Color color, double diameter): base (name, id, opacity, color)
        {
            Diameter = diameter;
            Pi = 22 / 7;
        }

        public override double CalculateArea()
        {
            return Diameter * Diameter * Pi;
        }

        
    }
}
