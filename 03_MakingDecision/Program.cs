using System;
using System.CodeDom;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else Yapısı

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "melih")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}

            //---------------------------------------------

            //Console.Write("Lütfen ülkeyi giriniz: ");
            //string country;
            //country = Console.ReadLine();

            //Console.Write("Lütfen başkenti giriniz: ");
            //string capital;
            //capital = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye") // && veya & kullanılabilir.
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı veri.");
            //}

            //---------------------------------------------

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number;
            //number = int.Parse(Console.ReadLine());

            //if (number == 0)
            //{
            //    Console.WriteLine("Doğru sayı.");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı.");
            //}

            //---------------------------------------------

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //int exam1;
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //int exam2;
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //int exam3;
            //exam3 = int.Parse(Console.ReadLine());

            //int average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine(average);

            //string result = "Hata!";

            //if (average > 0 && average < 49)
            //{
            //    result = "Kotü sonuç.";
            //}
            //if (average > 50 && average < 74)
            //{
            //    result = "Orta sonuç.";
            //}
            //if (average > 75 && average < 101)
            //{
            //    result = "İyi sonuç.";
            //}

            //Console.WriteLine(result);

            //---------------------------------------------

            //Console.Write("Bir şehir giriniz: ");
            //string city;
            //city = Console.ReadLine();

            //if (city == "eskişehir" | city == "ankara" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir bulundu.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir bulunamadı");
            //}

            //---------------------------------------------

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username;
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Hatalı kullanıcı.");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı doğru.");
            //}

            #endregion

            #region Mod işlemleri ve Char ile Karar Yapısı

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("26'nın 5'e bölümünden kalan: " + result);

            //---------------------------------------------

            //Console.Write("Bir sayı giriniz: ");
            //int number2;
            //number2 = int.Parse(Console.ReadLine());

            //if (number2 % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            //---------------------------------------------

            //Console.Write("Lütfen bir takım sembolü giriniz: ");
            //char team;
            //team = char.Parse(Console.ReadLine());

            //if (team == 'e' | team == 'E')
            //{
            //    Console.WriteLine("Eskişehirspor");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Restoran Örneği

            //Console.WriteLine("CSharp Restoran");
            //Console.Write("------------------------");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine("-----Ana yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Mantar Sote");
            //    Console.WriteLine("İskender");
            //    Console.WriteLine("Kremalı Tavuk");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana yemekler-----");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Ezogelin Çorbası");
            //    Console.WriteLine("Tavuk Suyu Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Mantarlı Pizza");
            //    Console.WriteLine("Margherita");
            //    Console.WriteLine("Karışık Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Meyve Suyu");
            //    Console.WriteLine("Kola");
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçeceklerr-----");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Tiramisu");
            //    Console.WriteLine("Sütlaç");
            //    Console.WriteLine("Baklava");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //}

            #endregion

            #region Switch-Case Yapısı

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int month;
            //month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.WriteLine("Hatalı giriş."); break ;
            //}

            #endregion

            #region Basit Hesap Makinesi

            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("-----------------");
            Console.Write("Lütfen ilk sayıyı giriniz: ");
            int num1;
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            int num2;
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Yapılacak işlemi giriniz: ");
            char op;
            op = char.Parse(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("Sonuç: " + (num1 + num2));
                    break;
                case '-': 
                    Console.WriteLine("Sonuç: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Sonuç: " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Sonuç: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;
            }

            #endregion

            Console.ReadLine();
        }
    }
}
