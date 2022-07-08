using System;

namespace IndexImplementaion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "jklmnopq";
            var num = new int[] { 4, 2, 4, 63,44, 3 };
            Console.WriteLine(str[new Index(3, false)]);
            Console.WriteLine(num[^2]);
        }
    }
}
