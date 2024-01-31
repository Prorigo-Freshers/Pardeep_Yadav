using System;

namespace Palindrome
{
    internal class Program
    {
        int result = 0;
        int rem;

        public int CheckPlaindromeNo(int n)
        {
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                result = result * 10 + rem;
                n = n / 10;
            }
            if (result == temp)
            {
                Console.WriteLine("PalindromeNo");
            }
            else
            {
                Console.WriteLine("Not a PalindromeNo");
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program program = new Program(); 
            int number = 122; 
            program.CheckPlaindromeNo(number);
            Console.ReadLine();
        }
    }
}
