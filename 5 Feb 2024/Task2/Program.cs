using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNo
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            int[] a = { 2, 1, 2 };

            int max = a[0];
            int sec_max = a[-1];

            for(int i=1;i<a.Length;i++)
            {

                if (max < a[i])
                {
                    sec_max = max;
                    max= a[i];
                }
                else if(sec_max < a[i] && a[i]!=max) {
                sec_max = a[i];
                }
            }


            Console.WriteLine(sec_max);
            Console.ReadLine(); 


        }
    }
}
