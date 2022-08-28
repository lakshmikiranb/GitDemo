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

            customer customer1 = new customer()
            {
                EmpID = 1,
                EmpName = "Sourabh",
                EmpSalary = 50000
            };
            customer customer2 = new customer()
            {
                EmpID = 2,
                EmpName = "Shaili",
                EmpSalary = 60000
            };
            customer customer3 = new customer()
            {
                EmpID = 3,
                EmpName = "Saloni",
                EmpSalary = 55000
            };
            //Customer array
            customer[] customers = new customer[2];
            customers[0] = customer1;
            customers[1] = customer2;

            //here I am adding one more cutomer to customers array and building the programs  
            customers[2] = customer3;
        }
    }
    class customer
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

    }
}
