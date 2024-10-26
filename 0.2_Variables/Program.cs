using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0._2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double_Değişkenler
            ////double number1 = 5.2;
            ////Console.WriteLine(number1);
            ////Console.WriteLine("double: "+double.MinValue+" ve "+double.MaxValue+" arasında değerleri alır.");

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice = 14.85;
            //double orangePrice = 16.80;
            //double strawberryPrice = 22.35;
            //double peachPrice = 17.15;
            //double apricotPrice = 12.20;
            //double pearPrice = 13.80;

            //Console.WriteLine("Elma KG Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("Poartakal KG Fiyatı: "+ orangePrice + " TL");
            //Console.WriteLine("Çilek KG Fiyatı: "+ strawberryPrice + " TL");
            //Console.WriteLine("Şeftali KG Fiyatı: "+ peachPrice + " TL");
            //Console.WriteLine("Kayısı KG Fiyatı: "+ apricotPrice + " TL");
            //Console.WriteLine("Armut KG Fiyatı: " + pearPrice + " TL");

            //double appleKG = 1.24;
            //double orangeKG = 1.52;
            //double strawberryKG = 0.65;
            //double peachKG = 2.12;
            //double apricotKG = 2.15;
            //double pearKG = 1.65;

            //Console.WriteLine();
            //Console.WriteLine("***** Fatura *****");
            //Console.WriteLine();

            //Console.WriteLine("Elma Toplam Fiyat: " + appleKG+" x "+applePrice+" = "+applePrice * appleKG+ " TL");
            //Console.WriteLine("Portakal Toplam Fiyat: " + orangeKG + " x " + orangePrice + " = " + orangePrice * orangeKG+ " TL");
            //Console.WriteLine("Çilek Toplam Fiyat: " + strawberryKG + " x " + strawberryPrice + " = " + strawberryPrice * strawberryKG + " TL");
            //Console.WriteLine("Şeftali Toplam Fiyat: " + peachKG + " x " + peachPrice + " = " + peachPrice * peachKG + " TL");
            //Console.WriteLine("Kayısı Toplam Fiyat: " + apricotKG + " x " + apricotPrice + " = " + apricotPrice * apricotKG + " TL");
            //Console.WriteLine("Armut Toplam Fiyat: " + pearKG + " x " + pearPrice + " = " + pearPrice * pearKG + " TL");

            //double totalPrice = applePrice * appleKG + orangePrice * orangeKG + strawberryPrice * strawberryKG + peachPrice * peachKG + apricotPrice * apricotKG + pearPrice * pearKG;
            //Console.WriteLine();

            //Console.WriteLine("--------------Toplam Tutar: "+ totalPrice);

            #endregion

            #region Char_Değişkenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden_Veri_Girişi_String

            //Console.WriteLine("****** C# HavaYolları Yolcu Bilgisi ******");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict,
            //    passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("***** Yolcu Bileti *****");
            //Console.WriteLine();

            //Console.WriteLine("Yolcu Adı-Soyadı: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber);
            //Console.WriteLine("Yolcu Yaşı: " + passengerAge);
            //Console.WriteLine("Yolcu Adres Bilgileri: " + passengerDistrict + "/" + passengerCity);

            #endregion

            #region Klavyeden_Veri_Girişi_Int

            //int shoesPrice, commputerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //commputerPrice = 20000;
            //chairPrice = 500;
            //tvPrice = 12000;

            //int shoesCount, commputerCount, chairCount, tvCount;
            //Console.Write("Lütfen Almak İstediğiniz Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); // Parse dönüştürme Methodu

            //Console.Write("Lütfen Almak İstediğiniz Bilgisayar Sayısını Giriniz: ");
            //commputerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Almak İstediğiniz Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Almak İstediğiniz TV Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + commputerCount * commputerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("TOPLAM TUTAR: "+totalPrice+" TL");

            #endregion

            #region Klavyeden_Veri_Girişi_OndaLıklı

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalama Notunuz: "+result);
            #endregion

            #region Klavyeden_Veri_Girişi_Karakter

            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Seçiniz (K/E): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: "+gender);

            #endregion

            Console.Read();
        }
    }
}