using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate double SquareRoot(double number);

    class FunctionLambdaDemo
    {
        static void Main(string[] args)
        {
           
           

            Console.WriteLine("---------------------");

            

            //    public delegate void GreetUser(string username,string pwd);
            Action<string, string> checkcredentials = (u, p) =>
            {
                if (u != "" && u == "bac" && p != "" && p == "abc@123")
                {
                    Console.WriteLine("U are logged in successfully");
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");
                }
            };
            checkcredentials("ba11c", "c@123");
            Console.WriteLine("---------------------------");

          
            Console.ReadKey();
        }
    }
}
