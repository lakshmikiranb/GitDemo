using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BookCategory
    {

        public int CatId { get; set; }
        public string CatName { get; set; }
        public int Description { get; set; }

        public BookCategory(int catid, string catname, string description)
        {
            CatId = catid;
            CatName = catname;
            Description = Description;

        }

        public override string ToString()
        {
            return String.Format("catid : catName : description ", CatId, CatName, Description);
        }
    }

    public class BookCategory1
    {
        static void Main()
        {
            Book b = new BookCategory1(123, "War and Pease", "Focuses on Nepoleon invasion of Russia");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
