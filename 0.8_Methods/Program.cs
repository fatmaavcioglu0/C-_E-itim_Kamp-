using System;
using System.Runtime.InteropServices;

namespace _0._8_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methods

            //// Metotlar sonuna mutlaka "()" alır.
            //// Geriye değer döndürmeyen metotlar
            //// Customer - Listele, Ekle, Sil, Güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //Console.WriteLine();
            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            //Console.WriteLine();

            #endregion

            #region String Paramatized Non-Return Methods 

            //Console.Write("Please Enter Your Name: ");
            //string customerName = Console.ReadLine();

            //Console.Write("Please Enter Your Surname: ");
            //string customerSurname = Console.ReadLine();

            //void GreetCustomer(string customersName, string customersSurname)
            //{
            //    Console.WriteLine("Welcome, " + customersName + " " + customersSurname + "!");
            //}

            //Console.WriteLine();

            //GreetCustomer(customerName, customerSurname);

            #endregion

            #region Int Paramatized Non-Return Methods 

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Non-Paramatized Methods That Return A Value

            //string CustomerName()
            //{
            //    return "Fatma Avcıoğlu";
            //}
            //Console.WriteLine(CustomerName()); 

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname; ;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region String Paramatized Methods That Return A Value

            //string country, capital,flag;

            //Console.Write("Please Enter Name Of Your Country: ");
            //country = Console.ReadLine();

            //Console.Write("Please Enter Name Of Your Capital: ");
            //capital = Console.ReadLine();

            //Console.Write("Please Enter Color Of Your Flag: ");
            //flag = Console.ReadLine();

            //string CountryCard(string countryName, string capitalName, string flagColor)
            //{
            //    string cardInfo = "Counrty: " + countryName + " / Capital: " + capitalName + " / Flag Color: " + flagColor;
            //    return cardInfo;
            //}

            //Console.WriteLine(CountryCard(country,capital,flag));

            //Console.WriteLine(CountryCard("Turkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Int Paramatized Methods That Return A Value

            //int Sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(10,5));
            //Console.WriteLine(Sum(45,52));
            //Console.WriteLine(Sum(71,17));
            //Console.WriteLine(Sum(22,359));

            #endregion

            #region Exapmle

            //string ExamResult(string studentsName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result < 50)
            //        return studentsName + " failed the exam" + "\t" + "Student's Average:" + result;
            //    else
            //        return studentsName + " passed the exam" + "\t" + "Student's Average:" + result; ;
            //}

            //Console.WriteLine(ExamResult("Fatma",100,100,100));
            //Console.WriteLine(ExamResult("Ali",50,40,50));
            //Console.WriteLine(ExamResult("Kadir",70,80,90));

            #endregion

            Console.Read();
        }
    }
}