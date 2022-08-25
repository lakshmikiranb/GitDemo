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
            string path = @"C:\Users\91837\Downloads\newkiran";
            string[] fnames = Directory.GetFiles(path);
            foreach (var item in fnames)
            {
                Console.WriteLine(item);
            }
            //string[] dirs = Directory.GetDirectories(path);
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //    string[] fnames=Directory.GetFiles(item);
            //    foreach (var item1 in fnames)
            //    {
            //        Console.WriteLine("Files");
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine("---------------");
            //}
            Console.ReadLine();
        }
    }
}
