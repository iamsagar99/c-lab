using System;

namespace HybridInheritance
{
  interface IG
    {
        void grandfather(); 
    }
    interface Ifather : IG
    {
         void car();
        
        void father();
    }
    class Son: IG, Ifather
    {
        public void car()
        {
            Console.WriteLine("I have car");
        }
        public void grandfather()
        {
            Console.WriteLine("G is my Grandfather");
        }
        public void father()
        {
            Console.WriteLine("F is my father");
        }
        public void son()
        {
            Console.WriteLine("I ma son");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Son s = new Son();
            s.father();
            s.grandfather();
            s.son();
            s.car();
        }
    }
}
