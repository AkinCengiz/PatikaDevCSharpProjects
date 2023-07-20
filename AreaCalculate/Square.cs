using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculate
{
    internal class Square : IPolygon
    {
        public int numberOfSides
        {
            get { return this.numberOfSides; }
            set { this.numberOfSides = 4; }
        }
        public double width { get; set; }

        public double heigth {
            get { return this.heigth; }
            set { this.heigth = width; }
        }


        public double AreaCalculate(params double[] sides)
        {
            return sides[0] * sides[0];
        }

        public double PerimeterCalculate(params double[] sides)
        {
            double perimeter = sides[0] * 4;
            return perimeter;
        }

        public Square()
        {
            Console.Write("Taban uzunluğunu giriniz     : ");
            this.width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nKarenin alanı       : {0,3}", AreaCalculate(this.width));
            Console.WriteLine("\nKarenin çevresi     : {0,3}", PerimeterCalculate(this.width));
        }
    }
}
