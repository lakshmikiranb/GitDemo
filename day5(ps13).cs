
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
{ 
  internal class Program
  {

     static void Main(string[] args)
     {

        int[] array1 = { 1,3,5,200,22,2244,213,111 };

        var big = from value in array1 where value > 100 select value;
        Console.WriteLine("Numbers that are greater than 100 are  :");

        foreach (var s in big)
        {
            Console.Write(s.ToString() + " ");
        }
        Console.Read();
    }
}