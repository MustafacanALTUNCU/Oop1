// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Collections // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "mustafa", "Emre", "Doğuş", "Hikmet" };
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            Console.WriteLine("-----collections--------");
            List<string> isimler2 = new List<string>() { "Mustafa", "Emre", "Doğuş", "Hikmet" };
            //isimler2.Add("Mustafa");böylede eklenebilir
            Console.WriteLine(isimler2[0]); 
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Alişan");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            
        }
    }
}