namespace TriangleDraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin taban uzunluğu : ");
            int a = Convert.ToInt32(Console.ReadLine());

            

            TriangleDal triangleDal = new TriangleDal();
            int[,] triangles = triangleDal.CreateTriangle(new Triangle()
            {
               edgeLenght = a
            });
            

            triangleDal.DrawTriangle(triangles);
        }
    }
}