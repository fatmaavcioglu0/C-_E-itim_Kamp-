using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0._3_DesicionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine(); 
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre doğru!");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre yanlış!");
            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı!");
            //}
            //else
            //{

            //    Console.WriteLine("Veriler Doğrulanamadı!");
            //}


            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi =int.Parse(Console.ReadLine());
            //if(sayi==5)
            //{
            //    Console.WriteLine("Sayı Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış! ");
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hatalı Not Girişi!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat!";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta!";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi!";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi!";
            //}
            //Console.WriteLine(result);

            //Console.Write("Lütfen Şehir Giriniz: ");
            //string city = Console.ReadLine();

            //if (city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "Admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez!");
            //}
            //else
            //{
            //    Console.Write("HOŞGELDİNİZ! ");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result2 = number1 % number2;
            //Console.Write("1. Sayının 2. Sayıya Bölümünden Kalan: " + result2);
            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' || team == 'g')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'F' || team == 'f')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'B' || team == 'b')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.Write("Yanlış Bir Giriş Yaptınız.");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçeçeckler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Ana Yemekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Köri Soslu Tavuk");
            //    Console.WriteLine("2 - Kızartma Tabağı");
            //    Console.WriteLine("3 - Fasulye - Pilav");
            //    Console.WriteLine("4 - Fırında Somon");
            //    Console.WriteLine("5 - Patlıcan Musakka");
            //    Console.WriteLine("------------------------------------------------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Çorbalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Mercimek Çorbası");
            //    Console.WriteLine("2 - Ezogelin Çorba");
            //    Console.WriteLine("--------------------------------------------");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Pizzalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Akdeniz Pizza");
            //    Console.WriteLine("2 - Margarita");
            //    Console.WriteLine("3 - Tavuklu Pizza");
            //    Console.WriteLine("--------------------------------------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------İçecekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("3 - Su");
            //    Console.WriteLine("---------------------------------------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------Tatlılar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Triliçe");
            //    Console.WriteLine("2 - Kazandibi");
            //    Console.WriteLine("3 - Sütlaç");
            //    Console.WriteLine("--------------------------------------------");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            Console.Read();


        }
    }
}
