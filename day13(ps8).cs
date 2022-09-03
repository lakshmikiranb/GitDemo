using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAppDemo
{
    class Product
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Apple", "Orange", "Kiwi", "Melon"
            };
            list.Add("Mango");
            list.Add("Watermelon");

            foreach (string item in list)
            {
                Console.WriteLine("Item: {0}", item);
            }
        }
    }
}