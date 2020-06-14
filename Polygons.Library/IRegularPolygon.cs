using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public interface IRegularPolygon
    {
        //All of the member of Interface are automatically public
        //These are just declaration and not the properties
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        //Interface are purely abstract class (only declaration and not implementation)
        double GetPerimeter();
        double GetArea();
    }
}
