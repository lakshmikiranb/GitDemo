using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary1;
namespace DelegatesDemo1
{
    public delegate void NameDelegate(string msg);


// Variables for Employee list
    public class Employee
    {
        public int id;
        public string name;
        public int dept_id;
        public int add_id;
    }

    // Variables for Department list
    public class Department
    {
        public int dept_id;
        public string dept_name;
    }

    // Variables for Address list
    public class Address
    {
        public int add_id;
        public string address_name;
    }

    class GFG
    {

        // Driver code
        static void Main(string[] args)
        {

            // Enter data for Employee list
            List<Employee> employees = new List<Employee>()
    {
        new Employee{ id = 234, name = "sravan kumar",
                    dept_id = 1},
        new Employee{ id = 244, name = "Monika",
                    dept_id = 2},
        new Employee{ id = 734, name = "harsha",
                    dept_id = 1},
        new Employee{ id = 533, name = "komal",
                    dept_id = 4},
    };

            List<Department> departments = new List<Department>()
    {
        new Department{ dept_id = 1, dept_name = "CSE" },
        new Department{ dept_id = 2, dept_name = "CSE" },
        new Department{ dept_id = 3, dept_name = "IT " },
    };

            // Join the employees and other two tables
            var result = (from stu in employees

                          join dept in departments on stu
                          .dept_id equals dept
                          .dept_id

                          select new
                          {
                              ID = stu.id,
                              Name = stu.name,
                              DeptName = dept.dept_name,
                          }).ToList();

            // Display the result
            foreach (var e in result)
            {
                Console.WriteLine("ID: " + e.ID +
                            "--> Name: " + e.Name +
                    "--> Department: " + e.DeptName);
            }
        }
    }
}