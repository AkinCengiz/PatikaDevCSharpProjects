namespace AreaCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cokgens = { "Üçgen", "Dikdörtgen", "Kare" };
            string mesaj = "Hesaplama yapılacak şekli secin : \n\n-----------------------------------\n ";
            for (int i = 0; i < cokgens.Length; i++)
            {
                mesaj += i + 1 + " " + cokgens[i] + " ";
            }

            mesaj += cokgens.Length + 1 + " Çıkış\n Tercihiniz\t: ";

            bool isContinue = true;

            while (isContinue)
            {
                Console.Write(mesaj);
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n-----------------------------------\n");
                Polygon polygon = new Polygon();
                switch (secim)
                {
                    case 1:
                        polygon.Poligon = new Triangle();
                        break;
                    case 2:
                        polygon.Poligon = new Rectangle();
                        break;
                    case 3:
                        polygon.Poligon = new Square();
                        break;
                    default:
                        isContinue = false;
                        break;
                }

                Console.Write("Devam etmek ister misiniz? (e/E)\t: ");
                isContinue = (Console.ReadLine().ToLower() == "e") ? true : false;
                Console.Clear();
                Console.WriteLine("\n-------------------------------------------\n");
            }
        }
    }
}