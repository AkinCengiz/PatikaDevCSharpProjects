using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculate
{
    internal class Rectangle:IPolygon
    {
        public int numberOfSides
        {
            get { return this.numberOfSides; }
            set { this.numberOfSides = 4; }
        }
        public double width { get; set; }
        public double heigth { get; set; }


        public double AreaCalculate(params double[] sides)
        {
            double area = 1;
            foreach (var side in sides)
            {
                area *= side;
            }
            return area;
        }

        public double PerimeterCalculate(params double[] sides)
        {
            double perimeter = 0;
            foreach (int side in sides)
            {
                perimeter += side;
            }

            return perimeter * 2;
        }

        public Rectangle()
        {
            Console.Write("Taban uzunluğunu giriniz\t: ");
            this.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYükseklik uzunluğunu giriniz\t: ");
            this.heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDikdörtgenin alanı\t: {0,3}",AreaCalculate(this.heigth,this.width));
            Console.WriteLine("\nDikdörtgenin çevresi\t: {0,3}", PerimeterCalculate(this.width, this.heigth));
        }
    }
}
