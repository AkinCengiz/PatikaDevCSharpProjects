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
        int width { get; set; }
        int heigt { get; set; }
        decimal AreaCalculate(params int[] sides);
        decimal PerimeterCalculate(params int[] sides);
    }
}
