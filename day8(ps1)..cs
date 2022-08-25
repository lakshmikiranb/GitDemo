using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConstructorDestructorEtcDemo
{
    public class Class
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("demofile.txt", FileMode.Truncate, FileAccess.Write);
            Console.WriteLine("Truncated");


            Console.ReadLine();
        }
    }
}
