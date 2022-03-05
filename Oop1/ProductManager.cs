using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    internal class ProductManager
    {
        public void Add(Product product)

        {
            Console.WriteLine(product.ProductName + "eklehndi");

        }
        public void Upgrade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        public int Topla1(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
