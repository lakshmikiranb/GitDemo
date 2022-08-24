using System;
public class Program
{
    enum deptnames
    {
        Purchase = 1, 
        Sales = 2, 
        Training = 3,
        Accounts = 4
    };
    public static void Main()
    {
        Console.WriteLine("The various stages in the deptnames are:\n");
        foreach (string str in Enum.GetNames(typeof(deptnames)))
        {
            Console.WriteLine(str);
        }
    }
}