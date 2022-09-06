using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   

    class CountClass
    {

        // Here, the static variable count is used to
        // store the count of objects created.
        static int count = 0;

        // constructor of the class, in which
        // count value will be incremented
        public CountClass()
        {
            count++;
        }

        // Method totalcount is used to return
        // the count variable.
        public static int TotalCount()
        {
            return count;
        }
    }

    class GFG
    {

        static void Main(string[] args)
        {

            // Printing the number of objects before
            // creating objects.
            Console.WriteLine("Total Books = " +
                           CountClass.TotalCount());

            // Creating the objects of DemoClass
            CountClass C1 = new CountClass();
            CountClass C2 = new CountClass();
            CountClass C3 = new CountClass();
            CountClass C4 = new CountClass();
            CountClass C5 = new CountClass();
            CountClass C6 = new CountClass();

            // Printing the number of objects after
            // creating 3 objects.
            Console.WriteLine("Total Books = " +
                            CountClass.TotalCount());
        }
    }
}