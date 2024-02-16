using System;
using System.Collections.Generic;

class Program
{
    static List<int> QuerySum(int[] A, int[,] B)
    {
        // Compute prefix sum array
        int[] prefixSum = new int[A.Length + 1];
        for (int i = 1; i <= A.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + A[i - 1];
        }

        // Perform queries
        List<int> result = new List<int>();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int L = B[i, 0];
            int R = B[i, 1];
            if (L == 0)
            {
                result.Add(prefixSum[R]);
            }
            else
            {
                result.Add(prefixSum[R] - prefixSum[L - 1]);
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int[,] B = { { 1, 3 }, { 0, 4 }, { 2, 4 } };

        List<int> result = QuerySum(A, B);

        Console.WriteLine(string.Join(", ", result)); // Output: 9, 15, 12
        Console.ReadLine();
    }
}
