namespace AreaCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cokgens = { "Üçgen", "Dikdörtgen", "Kare" };
            string mesaj = "Hesaplama yapılacak şekli secin : \n";
            for (int i = 0; i < cokgens.Length; i++)
            {
                mesaj += i + 1 + " " + cokgens[i] + " ";
            }

            Console.WriteLine(mesaj);
            int secim = Convert.ToInt32(Console.ReadLine());

            Polygon polygon = new Polygon();
            switch (secim)
            {
                case 1:
                    polygon.Poligon = new Triangle();
                    break;
                case 2:
                    polygon.Poligon = new Rectangle();
                    break;
                default:
                    polygon.Poligon = new Square();
                    break;
            }
        }
    }
}