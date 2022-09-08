using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnSafeCodeDemo
{
     class employee
    {
        static void Main(string[] args)
        { 
        Employee emp = new Employee();
        
 
            
            Console.WriteLine("Enter custid");
            emp.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter custname");
            emp.Empname = Console.ReadLine();
            Console.WriteLine("Enter phone no");
            emp.sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter custname");
            emp.mgr = Console.ReadLine();

            Console.ReadLine();

  //normal code Create a class employee, with employee id, empname, deptno, sal,mgr as properties.
        }
    }

class Employee
{
    public int Empid { get; set; }
        public string Empname { get; set; }
        public int deptno { get; set; }
        public int sal { get; set; }
        public string mgr { get; set; }

    }
}

