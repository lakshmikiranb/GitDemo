using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{


    struct anotherbook
    {
        public string id;
        public string name;
    }
    public class BookClass
    {
        public static void Main()
        {
            int nobook = 1000;
            anotherbook[] books = new anotherbook[nobook];
            int i, j, n = 1, k = 1;
            Console.Write("\n\nInsert the information of two books :\n");
            Console.Write("-----------------------------------------\n");
            for (j=0; j<=n; j++)
            {
                Console.WriteLine("Information of book {0} :", k);

                Console.Write("Input name of the book : ");
                books[j].id= Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].name= Console.ReadLine();
                k++;
                Console.WriteLine();
            }

            for (i = 0; i <=n; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i+1, books[i].id, books[i].name);
                Console.WriteLine();
            }

        }
    }
}
