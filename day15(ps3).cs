using System;

namespace AccessSpecifiersDemo1
{
    public class IBank
    {
        interface Saving
        {
            void GetCostomerInfo();
        }
        interface Current
        {
            void GetCostomerInfo();
        }


        class Customer : Saving, Current
        {
            //Explicit implementation of ILoanCustomer interface
            void Saving.GetCostomerInfo()
            {
                Console.WriteLine("Loan Customer ...");

            }
            //Explicit IBankCustomer of ILoanCustomer interface
            void Current.GetCostomerInfo()
            {
                Console.WriteLine("Bank Customer ...");

            }
        }

        //Test
        class Program
        {
            static void Main(string[] args)
            {
                Saving bc = new Customer();
                bc.GetCostomerInfo();

                Current lc = new Customer();
                lc.GetCostomerInfo();

            }
        }
    }
}


        