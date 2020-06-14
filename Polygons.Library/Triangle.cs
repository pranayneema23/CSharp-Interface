using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) : base(3,length)
        {

        }

        //When we inherit from abstrat class we must implement all abstract members
        //otherwise we have compile time error
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3)/4;
        }
    }
}
