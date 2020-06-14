using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square",square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon",octagon);

            Console.ReadKey();
        }

        public static void DisplayPolygon(string polygonType,dynamic polygon)
        {
            Console.WriteLine($"{polygonType} Number of sides : {polygon.NumberOfSides}");
            Console.WriteLine($"{polygonType} Side Length : {polygon.SideLength}");
            Console.WriteLine($"{polygonType} Perimeter : {polygon.GetPerimeter()}");
            Console.WriteLine($"{polygonType} Area : {polygon.GetArea()}");
            Console.Write("\n");
        }
    }
}
