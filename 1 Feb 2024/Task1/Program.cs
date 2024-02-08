using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Leader
{
    public static void Main(string[] args)
    {
        int[] inputArray = { 16, 17, 4, 3, 5, 2 };
        var result = FindTheLeaders(inputArray);

        foreach (var element in result)
        {
            Console.WriteLine($"{element}\n");
        }
    }

    public static List<int> FindTheLeaders(int[] inputArray)
    {
        int size = inputArray.Length;
        List<int> result = new List<int>();
        int max = inputArray[size - 1];
        result.Insert(0, max);

        if (size == 1)
        {
            return result;
        }

        for (int i = size - 2; i >= 0; i--)
        {
            if (max < inputArray[i])
            {
                max = inputArray[i];
                result.Insert(0, max);
            }
        }
        return result;
    }
}