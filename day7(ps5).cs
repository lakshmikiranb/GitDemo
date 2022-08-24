using System;



namespace ClassLibrary1
{
    public class Class1
    {
        static void Main()
        {
            string text;
            Console.WriteLine("Enter a string:");

            text = Console.ReadLine();
            text = text.ToUpper();

            Console.WriteLine("String in Uppercase : "+text);
        }
    }
}