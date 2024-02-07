using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 5, 6, 7, 8 };
        int n = arr.Length + 1;
        int totalSum = (n * (n + 1)) / 2;
        int arraySum = 0;
        foreach (int num in arr)
        {
            arraySum += num;
        }
        int missingNumber = totalSum - arraySum;
        Console.WriteLine( missingNumber);
        Console.ReadLine();
    }
}
