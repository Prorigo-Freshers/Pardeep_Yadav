using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] a = { 1, 2, 3, 4, -10 };
            int sum = 0, max = 0;

            for (int i = 0; i < a.Length; i++)
            {

                sum += a[i];
                max = Math.Max(sum, max);

                if (sum <= 0)
                {
                    sum = 0;
                }

            }
            Console.WriteLine(max);
            Console.ReadLine();
        }

       
    }

}
