using System;

namespace MethodOverloading
{
    class Overload
    {
        public void sum(int x,int y)
        {
            Console.WriteLine("Sum is:" + (x + y));
        }
        public void sum(string str,string s)
        {
            Console.WriteLine("sum is :" + (str + s));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overload o = new Overload();
            o.sum(3, 4);
            o.sum("sagar", " poudel");
            
        }
    }
}
