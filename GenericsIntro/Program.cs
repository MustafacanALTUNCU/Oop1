// See https://aka.ms/new-console-template for more information

using System;

namespace GenericsIntro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();//Listimizi çağırdık.Veri tipi olarak string verdik
            isimler.Add("Mustafa");//listimize mustafa elemanını ekledik
            Console.WriteLine(isimler.Length);
            isimler.Add("Doğuş");
            Console.WriteLine(isimler.Length);//Mylist classında tanımladığığmız length metodu bize items dizisinin eleman sayısını veriyor bu şekilde ekrana yazdırıyoruz
            foreach (var isim in isimler.Items)//bu döngü ile birlikte Items metodunu çalışstırarak items dizisinin içindeki elemanları dönüyoruz
            {
                Console.WriteLine(isim);//ekrana yazdırıyoruz
            }
          
        }
    }
}