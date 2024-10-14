using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // 2, 4, 6, 8
            // sarı, kırmızı, mavi, turuncu, beyaz
            // adana, eskişehir, istanbul, bursa
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman Sayısı] 

            //----------------------------------------------------------

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "yellow";
            //colors[2] = "black";
            //colors[3] = "white";
            //// colors[4] = "brown"; // System.IndexOutOfRangeException Error

            //Console.WriteLine(colors[3]); // white
            ////----------------------------------------------------------

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[2]); // Lyon
            ////----------------------------------------------------------

            //int[] nums = new int[10];

            //nums[0] = 1;
            //nums[1] = 2;
            //nums[2] = 3;
            //nums[3] = 5;
            //nums[4] = 6;

            //Console.WriteLine(nums[7]); // Automatically defines the index as 0
            ////----------------------------------------------------------

            //string[] names = { "Melih", "Murat", "Osman", "Kemal" };
            //Console.WriteLine(names[0]); // Melih

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Turuncu", "Beyaz", "Siyah", "Kahverengi", "Mor" };

            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            ////----------------------------------------------------------

            //int[] numbers = { 15, 84, 1561, 14, 92, 45, 87, 1248, 546 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]); // 15 84 45 87 1248 546
            //    }
            //}
            ////----------------------------------------------------------

            //char[] symbols = { 'A', 'b', 'e', '*', '/', '?' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}
            ////----------------------------------------------------------

            //int[] myArray = { 18, 91, 54, 75, 61, 185, 55, 15, 64 };

            //int maxNum = myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNum); // 185

            #endregion

            #region Dizi Metotları

            //string[] names = { "melih", "yavuz", "cihan", "kemal" };
            //Console.WriteLine(names.Length); // Dizi boyutu: 4
            ////----------------------------------------------------------

            //int[] numbers = { 15, 41, 9, 150, 98, 65, 1, 76, 22 };

            //Array.Sort(numbers); // Küçükten büyüğe sırala

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Reverse(numbers); // Diziyi terse çevir

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int index = Array.IndexOf(numbers, 150); // 150 sayısının index numarası
            //Console.WriteLine(index);

            //Console.WriteLine("Max: " + numbers.Max());
            //Console.WriteLine("Min: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            string[] cities = new string[5];

            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. şehri giriniz: ");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine("-----------------");
            Console.WriteLine();

            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            //----------------------------------------------------------

            int[] array1 = { 15, 52, 3, 16, 88, 63 };
            int sum = 0;

            for(int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }

            Console.WriteLine(sum); // 237

            Console.WriteLine("Çift sayılar");

            for(int i = 0;i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    Console.Write(array1[i] + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("\nTek sayılar");

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 1)
                {
                    Console.Write(array1[i] + " ");
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
