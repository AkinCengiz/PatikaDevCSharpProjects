using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculate
{
    internal class Triangle : IPolygon
    {
        public int numberOfSides
        {
            get { return numberOfSides;}
            set { this.numberOfSides = 3; }
        }
        public int width { get; set; }
        public int heigt { get; set; }
        public int aSide { get; set; }
        public int bSide { get; set; }
        public decimal AreaCalculate(params int[] sides)
        {
            decimal area = 1;
            foreach (int side in sides)
            {
                area *= side;
            }

            return area /= 2;
        }

        public decimal PerimeterCalculate(params int[] sides)
        {
            decimal perimeter = 0;
            foreach (int side in sides)
            {
                perimeter += side;
            }

            return perimeter;
        }

        public Triangle()
        {
            Console.Write("Taban uzunluğunu giriniz         : ");
            this.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYükseklik uzunluğunu giriniz   : ");
            this.heigt = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSağ kenar uzunluğunu giriniz   : ");
            this.bSide = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSol kenar uzunluğunu giriniz   : ");
            this.aSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nÜçgenin alanı       : {0,3}", AreaCalculate(this.width,this.heigt));
            Console.WriteLine("\nÜçgenin çevresi     : {0,3}", PerimeterCalculate(this.aSide,this.bSide,this.width));
        }
    }
}
