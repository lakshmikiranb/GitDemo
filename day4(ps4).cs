
using System;

public class Program
{
    public static void Main()
    {
        int first, second;

        Console.WriteLine("Enter the first number : ");
        first = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number : ");
        second = Convert.ToInt32(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine("First number is greater than the second number");
        }
        else
        {
            Console.WriteLine("First number is smaller than the second number");
        }
    }
}