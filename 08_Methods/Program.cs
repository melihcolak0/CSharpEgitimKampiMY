using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geriye Değer Döndürmeyen Metotlar

            // Başında "void" kullanılır.
            // Customer -> Listele, ekle, sil, güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Melih Çolak");
            //    Console.WriteLine("Ali Sarı");
            //    Console.WriteLine("Yavuz Görgülü");
            //    Console.WriteLine("Ayşe Yerli");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 23;
            //    int y = 54;
            //    int z = x + y;

            //    Console.WriteLine(z); // 77w
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customer)
            //{
            //    Console.WriteLine(customer);
            //}

            //WriteMethod("Melih Çolak");

            //void CustomerInfo(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerInfo("Yavuz", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int a, int b, int c)
            //{
            //    int result = a + b + c;
            //    Console.WriteLine(result);
            //}

            //Sum(13, 9, 65);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Çalık";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.Write(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryInfo (string countryName, string capital, string flagColor)
            //{
            //    string info = "Ülke: " + countryName + ", Başkent: " + capital + ", Bayrak Rengi: " + flagColor;
            //    return info;
            //}

            //Console.Write("Ülke adını giriniz: ");
            //string a = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Başkenti giriniz: ");
            //string b = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //string c = Console.ReadLine();

            //Console.WriteLine(CountryInfo(a, b, c));

            //Console.WriteLine(CountryInfo("İtalya", "Roma", "Yeşil-Beyaz-Kırmızı"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int x, int y)
            //{
            //    int result = x + y;
            //    return result;
            //}

            //Console.WriteLine(Sum(11, 23));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                double result = (exam1 + exam2 + exam3) / 3.0;

                if(result >= 50)
                {
                    return student + " isimli öğrenci, bu dersi " + result + " ortalama ile başarıyla tamamlamıştır."; 
                }
                else
                {
                    return student + " isimli öğrenci, maalesef bu dersi " + result + " ortalama ile tamamlayamamıştır.";
                }
            }

            Console.WriteLine(ExamResult("Ali", 50, 60, 30));
            Console.WriteLine(ExamResult("Şeyma", 100, 50, 60));
            Console.WriteLine(ExamResult("Metehan", 10, 20, 70));

            #endregion

            Console.ReadLine();
        }
    }
}
