using System;
using System.Collections;
namespace day5
{
    internal class Program
    {

        static void Main(string[] args)
        {
           Hashtable numberNames = nem Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add(1, "Two");
            numberNames.Add(1, "Three");
            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }
    }
}