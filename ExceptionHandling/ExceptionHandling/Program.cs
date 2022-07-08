using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, division, age;
            Console.WriteLine("Enter two number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                division = num1 / num2;
                Console.WriteLine(division);
                Console.WriteLine("Enter your age");

                age = Convert.ToInt32(Console.ReadLine());

                CheckAge(age);
            }
            catch (System.DivideByZeroException error)
            {
                Console.WriteLine("Attempted to divide by zero");
            }


            
        
            finally
            {
                Console.WriteLine("Program has been terminated");

            }

        }

        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Minimum Voter age should be greater than 18");
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }
        }

    }
}
