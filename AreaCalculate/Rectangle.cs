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
        public int width { get; set; }
        public int heigt { get; set; }


        public decimal AreaCalculate(params int[] sides)
        {
            decimal area = 1;
            foreach (var side in sides)
            {
                area *= side;
            }
            return area;
        }

        public decimal PerimeterCalculate(params int[] sides)
        {
            decimal perimeter = 0;
            foreach (int side in sides)
            {
                perimeter += side;
            }

            return perimeter * 2;
        }

        public Rectangle()
        {
            Console.Write("Taban uzunluğunu giriniz     : ");
            this.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYükseklik uzunluğunu giriniz : ");
            this.heigt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDikdörtgenin alanı       : {0,3}",AreaCalculate(this.heigt,this.width));
            Console.WriteLine("\nDikdörtgenin çevresi     : {0,3}", PerimeterCalculate(this.width, this.heigt));
        }
    }
}
