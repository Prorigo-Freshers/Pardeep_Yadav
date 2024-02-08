using System;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int targetValue = 3;
            int Count = 0;
            bool isValuePresent=false;

            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] > targetValue)
                {
                    Count++;
                }

                if (A[i] == targetValue)
                {
                    isValuePresent = true; 
                }


           
            }

            if (isValuePresent)
            {
                Console.WriteLine(Count);
            }
            else
            {
                Console.WriteLine(-1);
            }
         

          
            Console.ReadLine();
        }
   

    }


}
