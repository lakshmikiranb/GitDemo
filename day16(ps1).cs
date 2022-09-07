using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary1;

namespace DelegatesDemo1
{
   public class day16
   {
        static void Main(string[] args)
        {
            StringLength sl = new StringLength();

            Console.WriteLine("Input the string : ");
            StringLengthDelegate sld = new StringLengthDelegate(sl.len);
            Console..WriteLine("Enter the string :");
            string k = Console.ReadLine();
            int i = sld.Invoke(k);
            Console.Write("Length of the string is :"+i) ;

           
        }
   }
}

