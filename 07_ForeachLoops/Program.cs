using System;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach(1, 2, 3, 4)

            // 1: Değişken Türü
            // 2: Değişken Adı
            // 3: In
            // 4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "varşova", "barcelona", "istanbul"};

            //Console.WriteLine("------Cities------");

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 15, 65, 47, 2, 654, 4651, 541, 847, 475, 74, 81 };

            //Console.WriteLine("------Numbers------");

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("------Even Numbers------");

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.Write(number + " ");
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("------Sum------");

            //int sum = 0;

            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}

            //Console.WriteLine(sum);
            //Console.WriteLine();
            //----------------------------------------------------

            //List<int> numbers = new List<int>() { 145, 28, 54, 15, 3 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            ////----------------------------------------------------

            //string word = "Merhaba";

            //foreach (char w in word)
            //{
            //    Console.Write(w + " ");
            //}

            #endregion

            #region C# Eğitim Kampı Sınav Uygulaması

            Console.WriteLine("C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.Write("Lütfen sınıftaki öğrenci sayısını giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen sınav sayısını giriniz: ");
            int exam = int.Parse(Console.ReadLine());

            string[] studentsName = new string[studentCount];
            double[] studentsGradeAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
                studentsName[i] = Console.ReadLine();

                int sumOfGrades = 0;

                for (int j = 0; j < exam; j++)
                {
                    Console.Write($"{studentsName[i]}'nin {j + 1}. sınav notunu giriniz: ");
                    int examGrade = int.Parse(Console.ReadLine());
                    sumOfGrades += examGrade;
                }

                studentsGradeAvg[i] = sumOfGrades / exam;

                Console.WriteLine();                
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentsName[i]}'nin not ortalaması: {studentsGradeAvg[i]}");

                Console.WriteLine();

                if (studentsGradeAvg[i] >= 50)
                    Console.WriteLine($"{studentsName[i]} dersi geçmiştir.");
                else
                    Console.WriteLine($"{studentsName[i]} dersten kalmıştır. Ders tekrar alınmalıdır.");

                Console.WriteLine();
                Console.WriteLine();
            }

            #endregion


            Console.ReadLine();
        }
    }
}
