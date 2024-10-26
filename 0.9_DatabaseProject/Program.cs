using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._9_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net C#'ta SQL olanaklarını kullanmamızı sağlayan bir çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1 - Kategoriler");
            Console.WriteLine("2 - Ürünler");
            Console.WriteLine("3 - Siparişler");
            Console.WriteLine("4 - Çıkış Yap");
            Console.WriteLine();
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=FATMA-PC\\SQLEXPRESS;" +
                "initial Catalog=EgitimKampiDB;integrated security=true"); // SqlConnection; Sql Bağlantısı İçin Kullanılacak komut
                                                                           // connection: SqlConnection sınıfında tanımlanmış bir nesne
                                                                           // Data Source: Sunucu Adı; initial catalog=Veri Tabanı İsmi;
                                                                           // integrated security=true: Bağlantının güvenilir olduğunu göstermek için

            connection.Open(); // Bağlantıyı açmak için 
            SqlCommand command = new SqlCommand("Select * From CategoryTable", connection); // Sorguyu oluşturduk, hangi veri tabanında olduğunu bildirmek için connection verdik.
            SqlDataAdapter adapter = new SqlDataAdapter(command); // C#'ta oluşturulan sorgu ile SQL Arasında Köprü Görevi Gören Sınıf
            DataTable dataTable = new DataTable(); // Verilere geçici belleğe almayı sağlar, yer ayırır
            adapter.Fill(dataTable); //  Geçici belleği doldurur.

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            connection.Close();

            Console.Read();
        }
    }
}
