using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDraw
{
    internal class CircleDal
    {
        public double AreaCircle(Circle circle)
        {
            return Math.Pow(circle.radius, 2) * Math.PI;
        }

        public double GetCircle(Circle circle)
        {
            return Math.PI * circle.radius * 2;
        }
        public void DrawCircle(int[,] dInts)
        {
            for (int i = 0; i <= dInts.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= dInts.GetUpperBound(1); j++)
                {
                    if (dInts[i, j] == 1)
                    {
                        Console.Write("{0,2}", "*");
                    }
                    else
                    {
                        Console.Write("{0,2}", " ");
                    }
                }

                Console.WriteLine();
            }
        }

        public int[,] CreateCircle(Circle circle)
        {
            int diameter = circle.radius * 2 - 1;
            int[,] drawingInts = new int[diameter, diameter];
            for (int i = 0; i < diameter; i++)
            {
                for (int j = 0; j < diameter; j++)
                {
                    if ((j >= diameter / 2 - diameter / 4 && j <= diameter / 2 + diameter / 4) && (i == diameter - 1 || i == 0))
                    {
                        drawingInts[i, j] = 1;
                    }
                    if ((i >= diameter / 2 - diameter / 4 && i <= diameter / 2 + diameter / 4) && (j == diameter - 1 || j == 0))
                    {
                        drawingInts[i, j] = 1;
                    }

                    if (circle.radius % 2 == 0)
                    {
                        if (i + j == diameter / 4 + 1 || j - i == diameter / 2 + diameter / 4)
                        {
                            drawingInts[i, j] = 1;
                        }
                    }
                    else
                    {
                        if ((i + j == diameter / 4 || j - i == diameter / 2 + diameter / 4) && (i>0 || j>0))
                        {
                            drawingInts[i, j] = 1;
                        }
                    }


                    if (i - j == diameter / 2 + diameter / 4)
                    {
                        drawingInts[i, j] = 1;
                    }
                    if (i + j == diameter + diameter / 2 + diameter / 4 - 1)
                    {
                        drawingInts[i, j] = 1;
                    }

                }
            }

            return drawingInts;
        }
    }
}
