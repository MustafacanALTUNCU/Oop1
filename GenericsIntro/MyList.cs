using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;//dizi tanımladık
       // constructor
        public MyList()
        {
            items = new T[0];//Yapıcı metotta items adında 0 itemlı bir dizi tanımladık 
            

        }
        public void Add(T item)//T veri tipinde değişken alan  bir metot tanımladık.
        {
            T[] tempArray = items;//önceki elemanlarımızın kaybolmasını önlemek için bir geçici dizi tanımladık burada önceki değerleri tutacağız
            items = new T[items.Length+1];//dizinin elemanını bir arttıracağız
            //diziyi bir döngü eşliğinde yazdıracağız
            for (int i = 0; i < tempArray.Length; i++)//tempArray'in bütün elemanlarını items'a geri atayacağız       
            {
                items[i] = tempArray[i];//iki diziyi birbiirine eşledik
            }
            items[items.Length-1] = item;
            
        }
        public int Length { get { return items.Length; } }//bu metot eleman sayısını bize veriyor
        public T[] Items { get { return items; } }//bu metot bize items elemanlarını gösteriyor
    }
      
}
