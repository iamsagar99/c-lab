using System;

namespace Enemuration

{
    class Program
    {
        enum Continents
        {
            Asia,
            Africa,
            Europe,
            SouthAmerica,
            NorthAmerica,
            Antartica,
            Australia
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Continents in world:");
            Console.WriteLine(Continents.Asia + "is no." + (int)Continents.Asia);
        }
    }
}
