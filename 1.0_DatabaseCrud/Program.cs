using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create - Read - Update - Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=FATMA-PC\\SQLEXPRESS;" +
            //    "Initial Catalog=EgitimKampiDB;Integrated Security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into CategoryTable(CategoryName) values (@p1)", connection); // SQL'de oluşturduğumuz CatergoryTable adlı tabloya ekleme yapıyoruz.
            //command.Parameters.AddWithValue("@p1", categoryName); // p1 parametresi, categoryName'de aldığım değer. @ SQL'de değişken tanımlamak için kullanılır.
            //                                                      // (productName,price,stock)values(@p1,@p2,@p3) => productName=p1, price=p2, stock=p3
            //command.ExecuteNonQuery(); // Koşulsuz bir şekilde sorguyu çalıştır. Soru çalıştıktan sonra değişiklikler Veri Tabanına yansıtılır.
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Eklemek İstediğiniz Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection1= new SqlConnection("Data Source=FATMA-PC\\SQLEXPRESS;" +
            //    "Initial Catalog=EgitimKampiDB;Integrated Security=true;");
            //connection1.Open();
            //SqlCommand command1 = new SqlCommand("insert into ProductTable(ProductName,ProductPrice,ProductStatus)" +
            //    " values (@productName,@productPrice,@productStatus)",connection1);
            //command1.Parameters.AddWithValue("@productName",productName); 
            //command1.Parameters.AddWithValue("@productPrice",productPrice); 
            //command1.Parameters.AddWithValue("@productStatus", true); 
            //command1.ExecuteNonQuery();
            //Console.WriteLine("Ürün Ekleme Başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection2 = new SqlConnection("Data Source=FATMA-PC\\SQLEXPRESS;" +
            //    "Initial Catalog=EgitimKampiDB;Integrated Security=true;");
            //connection2.Open();

            //SqlCommand command2 = new SqlCommand("Select *From ProductTable", connection2);
            //SqlDataAdapter adapter = new SqlDataAdapter(command2);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection2.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection3 = new SqlConnection("Data Source=FATMA-PC\\SQLEXPRESS;" +
            //    "Initial Catalog=EgitimKampiDB;Integrated Security=true;");
            //connection3.Open();

            //SqlCommand command3 = new SqlCommand("Delete From ProductTable Where ProductID=@productId", connection3);
            //command3.Parameters.AddWithValue("@productId", productId);
            //command3.ExecuteNonQuery();

            //connection3.Close();

            //Console.WriteLine("Silme İşlemi Tamamlandı!");

            #endregion

            #region Ürün Güncelleme

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productId1=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName1=Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice1=decimal.Parse(Console.ReadLine());

            //SqlConnection connection4 = new SqlConnection("Data Source=FATMA-PC\\SQLEXPRESS;" +
            //    "Initial Catalog=EgitimKampiDB;Integrated Security=true;");
            //connection4.Open();

            //SqlCommand command4 = new SqlCommand("Update ProductTable Set ProductName=@productName1,ProductPrice=@productPrice1" +
            //    " where ProductID=@productId1",connection4);
            //command4.Parameters.AddWithValue("@productName1", productName1);
            //command4.Parameters.AddWithValue("@productPrice1", productPrice1);
            //command4.Parameters.AddWithValue("@productId1", productId1);
            //command4.ExecuteNonQuery();

            //connection4.Close();
            //Console.WriteLine("Ürün Güncelleme İşlemi Başarılı!");

            #endregion

            Console.Read();

        }
    }
}
