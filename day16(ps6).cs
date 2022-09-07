using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatesDemo1
{
     static void Main(string[] args)
     {
        string str1 = "";
        string str2 = "";
        string str3 = "";

        Console.Write("Enter string1: ");
        str1 = Console.ReadLine();

        Console.Write("Enter string2: ");
        str2 = Console.ReadLine();

        str3=String.Concat(str1, str2);

        Console.WriteLine("Concatenated string is: {0}", str3);
    }
}