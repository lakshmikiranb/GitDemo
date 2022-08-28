using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datastructuresday
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Student[] S = { new Student(), new Student() };

                S[0].SetStudent(101, "Rohit", 5000);
                S[1].SetStudent(102, "Virat", 8000);

                S[0].PrintStudent();
                S[1].PrintStudent();
            }
        
    }
    
}
