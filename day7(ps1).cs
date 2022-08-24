using System;

namespace ClassLibrary1
{
    public class Class1
    {
        static void Main()
        {
            string str1, str2;

          
            Console.WriteLine("Enter the first string : ");
            str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string : ");
            str2 = Console.ReadLine();

           
            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Both strings are equal");
            }
            else
            {
               
                Console.WriteLine("Not equal");
            }
        }
    }
}