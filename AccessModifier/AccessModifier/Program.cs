using System;

namespace AccessModifier
{
    class Access
    {
        private int x;
        protected int y;
        public int z;
        public int privatedata(int m)
        {
           return x = m+5;
           
        }

    }
    
    class Program: Access
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            a.z = 5;
            Console.WriteLine("Public type:"+a.z);
            Console.WriteLine("Private Type:" + a.privatedata(3));
            // class program inherits the class access to access protected member
            Program p = new Program();
            p.y = 30;
            Console.WriteLine("Protectd member is" + p.y);
        }
    }
}
