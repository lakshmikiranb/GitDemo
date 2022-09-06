using System;

namespace AccessSpecifiersDemo1
{


    public abstract class Person
    {
        public abstract void person();      // abstract class method
    }
    public class Employee : Person     // inheritance
    {
        public override void person()
        {
            Console.WriteLine("This is first animal");
        }
    }
    public class Manager : Person   // another class inheritance
    {
        public override void person()
        {
            Console.WriteLine("This is second animal");
        }
    }
    public class Clerk : Person   // another class inheritance
    {
        public override void person()
        {
            Console.WriteLine("This is second animal");
        }
    }
    public class main_method
    {
        public static void Main()      // main method
        {
            Person a;
            a = new Employee();
            a.person();
            a = new Manager();
            a.person();
            a = new Clerk();
            a.person();

            Console.ReadLine();
        }
    }
}