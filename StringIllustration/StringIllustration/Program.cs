using System;

namespace StringIllustration
{
    class StringClass
    {
        string s;
        public StringClass(string str)
        {
            s = str;
            
        }
        public bool isPalindrome()
        {
            char[] StrArray = s.ToCharArray();
            Array.Reverse(StrArray);
            string str = String.Concat(StrArray);
            Boolean res = str.Equals(s);
            return res;
        }
        public void CountTokens()
        {
            Console.WriteLine($"No of tokens in {s} is:" + s.Length);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();

            StringClass p = new StringClass(s);

            if (p.isPalindrome())
                    Console.WriteLine("Palindrome");
            else
                    Console.WriteLine("Not Palindrome");
            p.CountTokens();

               
        }
    }
}
