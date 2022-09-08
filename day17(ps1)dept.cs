using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnSafeCodeDemo
{
     class dept
    {
        static void Main(string[] args)
        {
            Employee d = new Employee ();



        Console.WriteLine("Enter deptno");
            d.Deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter custname");
            d.Dname = Console.ReadLine();
            Console.WriteLine("Enter dname");
            d.loc = Console.ReadLine();
            

            Console.ReadLine();

  //normal code Create a dept class, with deptno,dname and location
        }
}

class Employee
{
    public int Deptno { get; set; }
    public string Dname { get; set; }
    public string loc { get; set; }
   

}
}
