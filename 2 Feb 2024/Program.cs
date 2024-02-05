using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingArray
{
    internal class Program
    {
        public static  int[] ReverseArray(int[] array , int i , int j)
        {
            int temp = 0;
           
            while (i < j)
            {
                temp= array[i]; array[i] = array[j]; array[j] = temp;
                i++;
                j--;
            }return array;

        }

        static void Main(string[] args)
        {


            int[] n = { 1, 2, 3, 4};
           
            int rotate = 2;

            ReverseArray(n, 0, n.Length - 1);
            ReverseArray(n, 0, rotate-1);
            ReverseArray(n, rotate, n.Length - 1);



        foreach (int i in n) {
                Console.Write(i + " ");
            }

            Console.ReadLine();


        }
    }
}
