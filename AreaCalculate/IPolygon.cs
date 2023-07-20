using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculate
{
    internal interface IPolygon
    {
        int numberOfSides { get; set; }
        double width { get; set; }
        double heigth { get; set; }
        double AreaCalculate(params double[] sides);
        double PerimeterCalculate(params double[] sides);
    }
}
