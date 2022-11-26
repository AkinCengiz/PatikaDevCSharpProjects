using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDraw
{
    class TriangleDal
    {
        public int[,] CreateTriangle(Triangle triangle)
        {
            int[,] draw = new int[triangle.edgeLenght, triangle.edgeLenght];
            for (int i = 0; i < triangle.edgeLenght; i++)
            {
                for (int j = 0; j < triangle.edgeLenght; j++)
                {
                    if ((i + j) == triangle.edgeLenght / 2)
                    {
                        draw[i, j] = 1;
                    }

                    if ((j - i) == triangle.edgeLenght / 2)
                    {
                        draw[i, j] = 1;
                    }

                    if (i == triangle.edgeLenght / 2)
                    {
                        draw[i, j] = 1;
                    }
                }
            }
            return draw;
        }

        public void DrawTriangle(int[,] drawInts)
        {
            for (int i = 0; i <= drawInts.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= drawInts.GetUpperBound(1); j++)
                {
                    if (drawInts[i, j] == 1)
                    {
                        Console.Write("{0,3}","*");
                    }
                    else
                    {
                        Console.Write("{0,3}"," ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
