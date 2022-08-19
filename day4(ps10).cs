using System;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rev = 0, rem;
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            {
                rem = num%10;
                rev = rev*10 + rem;
                num/=10;
            }
            Console.Write("Reverse of the Number: " + rev);
        }
    }