using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* We want to create a program called paint like the one you have on your computer
                Create an abstract class called Shape
                The class has some properties – Name, Id , Opacity , Color
                The opacity is an enum Type having 3 values “Solid-SemiSolid-Transparent”
                The color is an enum having 5 values “Red – Green – Yellow – Blue – Orange “
                The abstract class has an abstract method called CalculateArea();
                        And a virtual method called ShowShapeData();
                        Create three classes inherit from it circle – square – rectangle
                        The square has property width
                The circle has property diameter and a field called PI equals 22 / 7
                The rectangle has two properties length and width
                Create constructors storing all properties and show data for all shapes */

            Square squareOne = new Square("Square one", 01, Opacity.Solid, Color.Blue, 3);
            Circle circleOne = new Circle("Circle one", 02, Opacity.SemiSolid, Color.Red, 4);
            Rectangle rectangleOne= new Rectangle("Rectangle one", 03, Opacity.Transparent, Color.Yellow, 5, 6);

            squareOne.ShowShapeData();
            circleOne.ShowShapeData();
            rectangleOne.ShowShapeData();
            Console.ReadLine();

        }
    }
}
