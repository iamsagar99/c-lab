using System;

namespace Inheritance
{
    class Animal
    {
        public string name;
        public void Show()
        {
            Console.WriteLine("We are in animal Kingdom");
        }
    }
    // single inheritance
    class WaterAnimal :Animal 
    {
      protected string color;
      
      public void genus()
        {
            Console.WriteLine("I am" + name);
        }
    }
    //hierarchical inheritance
    class Fish :  WaterAnimal
    {
        public Fish()
        {
            Console.WriteLine("i am fissh");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Show();
            WaterAnimal w = new WaterAnimal();
            w.name = "Whale";
            w.Show();
            w.genus();

            Fish f = new Fish();
            f.name = "shark";
            f.genus();
            f.Show();

            


        }
    }
}
