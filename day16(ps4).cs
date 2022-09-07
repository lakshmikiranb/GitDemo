using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary1;
namespace DelegatesDemo1
{
    public delegate void NameDelegate(string msg);

    public class Product
    {
        public string productId;
        public string productName;

        public Product(string productId, string productName)
        {
            this.productId = productId;
            this.productName = productName;
        }

        public void ShowProductId(string msg)
        {
            Console.WriteLine($"{msg} {this.productId}");
        }

        public void ShowProductName(string msg)
        {
            Console.WriteLine($"{msg} {this.productName}");
        }
    }
}