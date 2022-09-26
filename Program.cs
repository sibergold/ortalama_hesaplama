using System;
namespace ortalama_hesaplama
{
class Program{
        static void Main(string[] args)
        {
           Console.WriteLine("Sayı gir.");
           int sayi=Convert.ToInt32(Console.ReadLine());
           Fibonacci(sayi);     
        }
     public static void Fibonacci(int len)
    {   int[] dizi=new int[len];
        int a = 0, b = 1, c = 0;
        dizi[0]=a; dizi[1]=b;
        Console.Write("{0} {1}", a, b);
        for (int i = 2; i < len; i++)
        {
            c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
          dizi[i]=c;
        }
        double sum=0;
        double ortalama=0;
       for(int i=0;i<len;i++)
       {
           sum+=dizi[i];
       }
       ortalama=sum/len;
     Console.WriteLine(" \nOrtalama= "+ ortalama);
     }
    }
}
