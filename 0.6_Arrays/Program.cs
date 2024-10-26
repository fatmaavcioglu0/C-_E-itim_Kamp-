using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Değişken Türü [] DiziAdı = new DeğişkenTürü [Eleman Sayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]); // görüntülemek istediğimiz elemanın indisini gireriz. (indis=boyut-1)

            //string[] cities = new string[5];
            //cities[0] = "Milan";
            //cities[1] = "Paris";
            //cities[2] = "NewYork";
            //cities[3] = "Budapest";
            //cities[4] = "Lyon";
            //Console.WriteLine(cities[3]);

            //int []numbers=new int[10];
            //numbers[0] = 50;
            //numbers[2] = 14;
            //numbers[3] = 17;
            //numbers[7] = 25;
            // Console.WriteLine(numbers[8]); // atama yapılmayan indisler 0 döndürür.

            //string[] cities = { "Prag", "Ankara", "Atina", "Bursa" };
            //Console.WriteLine(cities[0]); // 0 indisli eleman Prag olduğu için Prag sonucu verir.


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Yeşil", "Mavi", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ". Color: " + colors[i]); 
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion

            #region Dizideki En Büyük Elemanı Bulan Sayı

            //int[] myArray = { 47, 85, 95, 410, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Methodlar
            //int[] numbers = { 10, 707, 24, 680, 320, 153, 277, 86, 535, 168, 25, 122 };
            //Console.WriteLine("Diziznin boyutu: " + numbers.Length); // Lenght Methodu : Dizinin boyutunu yazdırır.
            //Console.WriteLine();

            //Array.Sort(numbers); // Sort Methodu: Dizinin elemanlarını küçükten büyüğe sıralar.
            //Console.WriteLine("Dizinin küçükten büyüğe sıralanmış hali : ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + ", ");
            //}

            //Array.Reverse(numbers); // Reverse Methodu : Diziyi tersten sıralar.
            //Console.WriteLine("Dizinin tersten sıralanmış hali : ");
            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int index = Array.IndexOf(numbers, 320); // IndexOf Methodu : Dizide aradığınız elemanın indexini gösterir. 
            //Console.WriteLine(index);

            //Console.WriteLine("Dizinin En Büyük Elemanı : "+numbers.Max()); // Max Methodu : Dizinin en büyük elemanını bulur.
            //Console.WriteLine("Dizinin En Küçük Elemanı : "+numbers.Min()); // Min Methodu : Dizinin en küçük elemanını bulur.

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");

            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

            //Console.Write("Çift Sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2== 0) 
            //    {
            //        Console.Write(numbers[i]+", ");
            //    }
            //}

            //Console.WriteLine();
            //Console.Write("Tek Sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.Write(numbers[i] + ", ");
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
