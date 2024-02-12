using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {

            int n, rem, sum = 0;

            for (int i = 1; i <= 200; i++)
            {
                n = i;
                while (n > 0)
                {
                    rem = n % 10;
                    sum = sum + (rem * rem * rem);
                    n = n / 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i + " ");
                }
                sum = 0;
            }
        }
    }
}