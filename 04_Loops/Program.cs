using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı"); // 5 kez C# Eğitim Kampı
            //}

            //---------------------------------------------------------------

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i); // 1-20
            //}

            ////---------------------------------------------------------------

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i); // 3 6 9 12 ... 45 48
            //}

            ////---------------------------------------------------------------

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet"); // finishValue kez Yaşasın Cumhuriyet
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i); // 5 10 15 20 ... 95 100
            //    }
            //}

            //---------------------------------------------------------------

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i; // 1 + 2 + 3 ... + 10 = 55
            //}

            //Console.WriteLine(totalvalue);

            //---------------------------------------------------------------

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i; // 2 + 4 + 8 + 10 ... + 16 + 18 = 90
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //---------------------------------------------------------------

            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++; // 7 14 21 28 35 42 49 56 -> 8 kez
            //    }
            //}

            //Console.WriteLine(count);

            //---------------------------------------------------------------

            //1-2-4-8-16-...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2; // 2 4 8 16 32 ... 8388608 16777216 -> 2^24
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler"); // 10 kez Merhaba Döngüler
            //    i++;
            //}

            //---------------------------------------------------------------

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i); // 3 6 9
            //    }
            //    i++;
            //}

            //---------------------------------------------------------------

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum); // 1 + 2 + 3 ... 9 + 10 = 55  

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //456

            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;//4.56 --> 4

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            sum = ones + tens + hundreds;

            Console.WriteLine(sum);

            #endregion

            Console.ReadLine();
        }
    }
}