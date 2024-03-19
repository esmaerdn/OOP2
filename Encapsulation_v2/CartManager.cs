using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_v2
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklenen ürün: "+ product.Name);
        }


        public void Add2(string productName, string Description, double price, int stock, double kdvOrani)
        {
            Console.WriteLine("Sepete eklenen ürün: " + productName);
        }


    }
}
