using System;

namespace ArrayIllustration
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int j = 0;
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements of array:");
            for(int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array is :");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
