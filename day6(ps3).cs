using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
{
class Employee
{
    public int eNum;
    public string eName;
    public int eSal;
    public int eDep;

    public Employee(int eNUM, string eName, int eSal, int eDep)
    {
        this.eNum=eNum;
        this.eName = eName;
        this.eSal = eSal;
        this.eDep = eDep;
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
    }
}