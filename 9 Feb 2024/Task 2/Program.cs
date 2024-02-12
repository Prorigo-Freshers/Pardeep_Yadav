


using System;

namespace DifferenceBetweenMaxEvenNum_MinOddNum
{
    internal class DifferenceBetweenMaxEvenNumMinOddNum
    {
        static void Main(string[] args)
        {
            // int[] arr = { 0, 2, 9 };
            int[] arr = { 5, 17, 100, 1 };

            int diff = differenceBtwMaxEvenAndMinOdd(arr);
            Console.WriteLine(diff);
        }

        public static int differenceBtwMaxEvenAndMinOdd(int[] arr)
        {
            int maxEven = int.MinValue;
            int minOdd = int.MaxValue;


            foreach (int n in arr)
            {
                if (n % 2 == 0 && n > maxEven)
                {
                    maxEven = n;
                }

                else if (n % 2 != 0 && n < minOdd)
                {
                    minOdd = n;
                }

            }

            int diff = maxEven - minOdd;
            return diff;

        }
    }
}