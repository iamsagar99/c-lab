
using System;

namespace AbstractClass
{
    abstract class Animal
    {
        
        public void name()
        {
            Console.WriteLine("I am animal");
        }
    }
    class Dog : Animal
    {
       public Dog()
        {
            Console.WriteLine("I am dog");
        }
    }

    class Program
    {
        private const string V = "sagar";

        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.name();
           
        }
    }
}
