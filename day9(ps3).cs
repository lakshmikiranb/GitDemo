using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datastructuresday
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<string> sports = new List<string>();
            sports.Add("Football");
            sports.Add("Tennis");
            sports.Add("Soccer");
            foreach (string s in sports)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("New List...");
            sports.Remove("Tennis"); // remove method
            foreach (string s in sports)
            {
                Console.WriteLine(s);
            }
        }
    }
}