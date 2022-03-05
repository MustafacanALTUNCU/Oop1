// See https://aka.ms/new-console-template for more information

using System;

namespace Oop1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "kalem", UnitPrice = 35 };
            ProductManager productManager= new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Upgrade(product1);
            productManager.Topla2(5, 6);
            int sonuc = productManager.Topla1(5, 6);
            Console.WriteLine(sonuc*2);
        }
    }
}