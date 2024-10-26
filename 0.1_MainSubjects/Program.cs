using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_MainSubjects // projeye verdiğimiz isim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YAZDIRMA_KOMUTLARI

            //Console.Write("Hello World"); // İmleç satırın sonunda.
            //Console.WriteLine("Hi!"); // İmleç alt satırda.

            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Başlangıçlar");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6 - İçecekler");
            //Console.WriteLine();

            #endregion

            #region STRING_DEGİŞKENLER

            //////string
            ////string name;
            ////name = "Fatma";
            ////Console.Write(name);
            ////

            //string customerName; // değişken tanımlarken Camel notasyonu kullanılır.
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** REZERVASYON KARTI *****");
            //Console.WriteLine();
            //Console.WriteLine("_________________________________________________");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Email. " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("_________________________________________________");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("_________________________________________________");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("Email. " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("_________________________________________________");
            #endregion

            #region INT_DEĞİŞKENLER

            ////int number = 24;
            ////Console.WriteLine(number);
            //int hamburgerPrice = 300;
            //int cokePrice = 25;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;
            //Console.WriteLine("***** MENÜ FİYATLARI *****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            //Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            //Console.WriteLine("-----Kola: " + cokePrice + " TL");
            //Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            //Console.WriteLine("-----Su: " + waterPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //int hamburgerCount = 2;
            //int cokeCount = 2;
            //int waterCount = 3;
            //int friesCount = 1;
            //int pizzaCount = 1;
            //int lemonadeCount = 1;

            //int totalPrice = hamburgerCount * hamburgerPrice + cokeCount * cokePrice + waterCount * waterPrice + friesCount * friesPrice + lemonadeCount * lemonadePrice + pizzaCount * pizzaPrice;

            //Console.WriteLine("***** FATURA *****");
            //Console.WriteLine();
            //Console.WriteLine("Hamburger Tutarı: " + hamburgerCount + " x " + hamburgerPrice + " = " + hamburgerPrice * hamburgerCount);
            //Console.WriteLine("Pizza Tutarı: " + pizzaCount + " x " + pizzaPrice + " = " + pizzaPrice * pizzaCount);
            //Console.WriteLine("Kızartma Tutarı: " + friesCount + " x " + friesPrice + " = " + friesPrice * friesCount);
            //Console.WriteLine("Kola Tutarı: " + cokeCount + " x " + cokePrice + " = " + cokePrice * cokeCount);
            //Console.WriteLine("Su Tutarı: " + waterCount + " x " + waterPrice + " = " + waterPrice * waterCount);
            //Console.WriteLine("Limonata Tutarı: " + lemonadeCount + " x " + lemonadePrice + " = " + lemonadePrice * lemonadeCount);
            //Console.WriteLine();
            //Console.WriteLine("----------TOPLAM TUTAR : "+totalPrice);

            #endregion

            Console.Read(); // Konsolu tutmak için kullandık. Enter'a basınca konsoldan ayrılır.

        }
    }
}