using System.Runtime.InteropServices;

namespace CircleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Yarıçap : ");
            int yaricap = Convert.ToInt32(Console.ReadLine());
            Circle circle = new Circle();
            circle.radius = yaricap;
            CircleDal circleDal = new CircleDal();
            int[,] shape = circleDal.CreateCircle(circle);
            Console.WriteLine("Yarıçapı : {0,3} olan çemberin\nAlanı : {1,3} birimkare\nÇevresi : {2,3} birimdir",yaricap,circleDal.AreaCircle(circle),circleDal.GetCircle(circle));
            Console.WriteLine("Yukarıda bilgileri verilen çemberin görünümü...");
            circleDal.DrawCircle(shape);
            
            
            

        }
    }
}