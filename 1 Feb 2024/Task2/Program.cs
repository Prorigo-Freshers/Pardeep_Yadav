using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSingleInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,2,3,1};
            var ans = array[0];
            for(int i=1; i<array.Length; i++)
            {
              ans = ans ^ array[i];
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
