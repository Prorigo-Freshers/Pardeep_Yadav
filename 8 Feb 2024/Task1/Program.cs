using System;

class Program
{
    static bool IsEven(int num)
    {
        return (num & 1) == 0;
    }

    static void Main(string[] args)
    {
        int number = 11;
        if (IsEven(number))
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }


        Console.ReadLine();
    }
}
