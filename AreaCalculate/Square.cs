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
        public int width { get; set; }
        public int heigt {
            get { return this.heigt; }
            set { this.heigt = width; }
        }


        public decimal AreaCalculate(params int[] sides)
        {
            return sides[0] * sides[0];
        }

        public decimal PerimeterCalculate(params int[] sides)
        {
            decimal perimeter = sides[0] * 4;
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
