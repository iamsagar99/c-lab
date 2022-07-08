using System;

namespace ConstructorOverloading
{
    class ConstructOverLoad
    {
        int a, b;
        String s;
        public ConstructOverLoad(int x,int y)
        {
            a = x;
            b = y;
        }
        public ConstructOverLoad(int m, String n)
        {
            a = m;
            s = n;
        }
        public void Display1()
        {
            Console.WriteLine("Sum is " + (a + b));
        }
        public void Display2()
        {
            Console.WriteLine("Roll NO:{0} and Name:{1}", a, s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstructOverLoad C = new ConstructOverLoad(2, 3);
            C.Display1();
            ConstructOverLoad D = new ConstructOverLoad(1, "Ram");
            D.Display2();
        }
    }
}
