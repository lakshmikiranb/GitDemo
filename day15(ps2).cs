using System;

namespace AccessSpecifiersDemo1
{
    public class IBank
    {
        interface PrintBalance
        {
            void GetCostomerInfo();
        }
        interface CalculateInterest
        {
            void GetCostomerInfo();
        }


        class Customer : PrintBalance, CalculateInterest
        {
            //Explicit implementation of ILoanCustomer interface
            void PrintBalance.GetCostomerInfo()
            {
                Console.WriteLine("Loan Customer ...");

            }
            //Explicit IBankCustomer of ILoanCustomer interface
            void CalculateInterest.GetCostomerInfo()
            {
                Console.WriteLine("Bank Customer ...");

            }
        }

        //Test
        class Program
        {
            static void Main(string[] args)
            {
                PrintBalance bc = new Customer();
                bc.GetCostomerInfo();

                CalculateInterest lc = new Customer();
                lc.GetCostomerInfo();

            }
        }
    }
}


        