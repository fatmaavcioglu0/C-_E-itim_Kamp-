using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._7_Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizilerde Foreach Döngüsü

            // Foreach (1; 2; 3; 4)

            // 1: Değişkenin Türü
            // 2: Değişkenin Adı
            // 3: In
            // 4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Varşova", "İstanbul" };

            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number); // dizinin elemanlarını tek tek görüntüler
            //}

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number); // dizinin elemanlarını şartlı görüntüler.
            //    }
            //}

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number; // Numbers dizisindenki sayıları tek tek toplar.
            //}
            //Console.WriteLine(total);

            #endregion

            #region List İle Foreach Kullanımı

            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Bir Kelimenin Harflerini Ayırma

            //string word = Console.ReadLine();

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması ***** ");
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            string[] studentNames = new string[studentCount];

            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adı: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {studentNames[i]} isimli öğrencinin {j + 1}. sınav notu: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notların toplamı
                }
                studentExamAverage[i] = totalExamResult / 3;
                Console.WriteLine();
            }

            double totalExam = 0;

            foreach (int studentExam in studentExamAverage)
            {
                totalExam += studentExam;
            }

            Console.WriteLine("Sınıf Başarı Oranı: " + totalExam / studentCount);

            // Öğrencilerin Ortalaması Ve Geçip Kalma Durumları

            Console.WriteLine();
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($" {studentNames[i]} adlı öğrencinin ortalaması: {studentExamAverage[i]}");
                if (studentExamAverage[i] < 50)
                {
                    Console.WriteLine("Case: KALDI");
                }
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine("Case: GEÇTİ");
                }

            }

            #endregion

            Console.Read();
        }
    }
}
