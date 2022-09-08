using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegatesDemo
{
    //delegate also called event handler
    class Employee
    {
        public string employeeID;
        public string Name;
        public string eventHeld;
        public int eventId;

        public Employee(string eID, string eName, string eEvents, int eId)
        {
            this.employeeID = eID;
            this.Name = eName;
            this.eventHeld = eEvents;
            this.eventId = eId;
        }

        public static void PrintDataBase()
        {

        }

        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("PALI_e1", "Parvez Ali", "FOOTBALL", 1));
            employees.Add(new Employee("AALI_e2", "Ashik Ali", "FOOTBALL", 1));
            employees.Add(new Employee("AALI_e3", "Aftab Ali", "CHESS", 2));
            employees.Add(new Employee("AALI_e4", "Arif Ali", "CRICKET", 3));

            Menu.MenuPrinting();
            Console.WriteLine("\nPlease Enter Your Choice");
            string Choice = Console.ReadLine();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }

    public class Menu
    {
        public static void MenuPrinting()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("1. DataBase");
            Console.WriteLine("2. Events Held");
            Console.WriteLine("3. Name of Emplyee");

        }
    }
}