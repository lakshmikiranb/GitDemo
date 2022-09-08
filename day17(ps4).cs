using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary;
namespace DelegatesDemo
{
    //delegate also called event handler
    public delegate void HandleInsertUpdateEmployee(Employee e);

    class employeeOperations : EventArgs
    {
        public static event HandleInsertUpdateEmployee InsertEvent;
        public static event HandleInsertUpdateEmployee UpdateEvent;
        //Event takes a parameter Employee object
        public static List<Employee> list = new List<Employee>();

        static void Main(string[] args)
        {
            InsertEvent += EmployeeOperations_InsertEvent;
            UpdateEvent += EmployeeOperations_UpdateEvent;

            Console.WriteLine("Menu 1 for Insert, 2 for Update");
            int ch = Convert.ToInt32(Console.ReadLine());
            Employee e = new Employee();
            switch (ch)
            {
                case 1:

                    //Console.WriteLine("Enter custid");
                    //c.custid = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Enter custname");
                    //c.custname = Console.ReadLine();
                    //Console.WriteLine("Enter phone no");
                    //c.phoneno = Convert.ToInt32(Console.ReadLine());
                    //static
                    e.empid = 1;
                    e.empname = "James";
                    e.phoneno = 14242;

                    InsertEvent(e);
                    break;
                case 2:

                    Console.WriteLine("Enter empid");
                    e.empid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter empname");
                    e.emptname = Console.ReadLine();
                    Console.WriteLine("Enter phone no");
                    e.phoneno = Convert.ToInt32(Console.ReadLine());
                    UpdateEvent(e);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }


            Console.Read();
        }

        private void InsertMethod(Employee e)
        {
            list.Add(e);
            Console.WriteLine("Added successfully");
            foreach (var item in list)
            {
                Console.WriteLine(item.empid);
                Console.WriteLine(item.empname);
                Console.WriteLine(item.phoneno);
            }
        }
        private void UpdateMethod(Employee e)
        {
            Employee found = list.Find(x => x.empid ==e.empid);
            found.empname = e.empname;
            found.phoneno = e.phoneno;






            Console.WriteLine("Updated successfully");
        }



        private static void CustomerOperations_UpdateEvent(Employee e)
        {
            //throw new NotImplementedException();
            employeeOperations operations = new employeeOperations();
            HandleInsertUpdateEmployee del = new HandleInsertUpdatEmployee(operations.UpdateMethod);
            del.Invoke(e);


        }

        private static void EmployeeOperations_InsertEvent(Employee e)
        {
            employeeOperations operations = new employeeOperations();
            HandleInsertUpdateEmployee del = new HandleInsertUpdateEmployee(operations.InsertMethod);
            del.Invoke(e);

        }
    }
}