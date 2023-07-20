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
        public double width { get; set; }

        public double heigth
        {
            get;
            set;
        }
        public int aSide { get; set; }
        public int bSide { get; set; }
        public double AreaCalculate(params double[] sides)
        {
            double sParameter = Convert.ToDouble(PerimeterCalculate(aSide, bSide, width) / 2);

            double area = Math.Sqrt((sParameter * (sParameter - aSide) * (sParameter - bSide) * (sParameter - width)));
            this.heigth = area / width * 2;
            return area;
        }


        public double PerimeterCalculate(params double[] sides)
        {
            double perimeter = 0;
            foreach (int side in sides)
            {
                perimeter += side;
            }

            return perimeter;
        }

        public Triangle()
        {
            Console.Write("Taban uzunluğunu giriniz\t: ");
            this.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSağ kenar uzunluğunu giriniz\t: ");
            this.bSide = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSol kenar uzunluğunu giriniz\t: ");
            this.aSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nÜçgenin alanı       : {0,3}", AreaCalculate(this.width,this.heigth));
            Console.WriteLine("\nÜçgenin çevresi     : {0,3}", PerimeterCalculate(this.aSide,this.bSide,this.width));
            Console.WriteLine("\nÜçgenin yüksekliği  : {0,3}", this.heigth);
        }
    }
}
