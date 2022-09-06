using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public  class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }

        public Book(int id,string name,int price, string author)
        {
            Id = id;
            Name = name;
            Price = price;
            Author = author;
            
        }

        public override string ToString()
        {
            return String.Format("id : Name : Price: {0}\nAuthor ", Id, Name,Price,Author);
        }
    }

    public class Book1
    {
        
        public void InsertData(int id, string name, int price, string author)
        {
            Book b = new Book(123,"War and Pease",500, "Leo Tolstoy");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}