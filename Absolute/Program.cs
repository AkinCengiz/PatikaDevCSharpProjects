namespace Absolute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, smallTotal = 0, bigTotal = 0;
            do
            {
                Console.WriteLine("Hesaplanacak değeri giriniz (Bitirmek için 67 giriniz.): ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 67)
                {
                    smallTotal += 67 - sayi;
                }
                else if (sayi > 67)
                {
                    bigTotal += Math.Abs(sayi - 67) * Math.Abs(sayi - 67);
                }
            } while (sayi != 67);

            Console.WriteLine("67 den küçük olanların toplamı : {0,3}\nBüyük olanların kareleri toplamı : {1,3}",
                smallTotal, bigTotal);
        }
    }
}