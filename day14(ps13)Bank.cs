using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Bank
    {
        public abstract void withdraw();
    }

    public class YesBank : Bank
    {
        public override void withdraw()
        {
            Console.WriteLine("Withdrawing cash from YesBank");
        }
    }

    public class NoBank : Bank
    {
        public override void withdraw()
        {
            Console.WriteLine("Withdrawing cash from NoBank");
        }
    }

    namespace Studytonight
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Bank b = new YesBank();
                b.withdraw();
                b = new NoBank();
                b.withdraw();
            }
        }
    }
}