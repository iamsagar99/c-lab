using System;

namespace StructureImplementation
{
    struct Distance
    {
         
        public void Dist(int x1, int y1, int x2, int y2)
        {
          double x =   Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
          Console.WriteLine("Distance is"+x);
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter point x1,y1");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point x2,y2");
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            Distance p = new Distance();
            p.Dist(a, b, c, d);


        }
    }
}
