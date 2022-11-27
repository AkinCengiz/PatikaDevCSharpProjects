using System.Globalization;

namespace DualAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane ikili üzerinde işlem yapmak istiyorsunuz : ");
            int dimension = Convert.ToInt32(Console.ReadLine());
            int[,] dualSerial = new int[dimension, 2];
            for (int i = 0; i <= dualSerial.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= dualSerial.GetUpperBound(1); j++)
                {
                    Console.WriteLine("{0}. sıradaki ikilinin {1}. terimini giriniz : ", i+1, j+1);
                    dualSerial[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] singleSerial = new int[dimension];
            for (int i = 0; i <= dualSerial.GetUpperBound(0); i++)
            {
                int x = 0;
                int y = 0;
                for (int j = 0; j <= dualSerial.GetUpperBound(1); j++)
                {
                    if (j == 0)
                    {
                        x = dualSerial[i, j];
                    }
                    else
                    {
                        y = dualSerial[i, j];
                    }
                }
                if (x != y)
                {
                    singleSerial[i] = x + y;
                }
                else
                {
                    singleSerial[i] = x * y * x * y;
                }
            }

            Console.WriteLine("===============================================================");
            
            foreach (int single in singleSerial)
            {
                Console.WriteLine(single);
            }
        }
    }
}