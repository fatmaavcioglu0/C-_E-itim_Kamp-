using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // For(x,y,z)
            // x: başlangıç
            // y. bitiş
            // z: artış-azalış miktarı

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Ekrrana Yazılmasını İstediğiniz Adedi Giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for(int i = 1;i<= finishValue;i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET!");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++) 
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine("  " + i);
            //    }
            //}

            //Console.WriteLine("+--------");
            //Console.WriteLine("  " + totalValue);

            //int count = 0;
            //for(int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda Bakteri Sayısı: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            #endregion

            #region SORU

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamnını yazınız.

            //int number, sum = 0;
            //Console.Write("Please enter a number: ");
            //number = int.Parse(Console.ReadLine());

            //while (number >= 1)
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
