using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Tablosune Veri Ekleme İşlemi
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("***** Menu Sipariş İşlem Paneli *****");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adını Giriniz: ");
            //string categoryName = Console.ReadLine();
            //Console.WriteLine("-------------------------------------------------");

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi");
            #endregion

            #region Ürün Tablosune Veri Ekleme İşlemi

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("***** Ürün Ekleme İşlemi Paneli *****");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Ürünün Adını Giriniz: ");
            //string productName = Console.ReadLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Ürünün Fiyatını Giriniz: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();



            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürününüz Başarıyla Eklendi");
            #endregion

            #region Ürün Tablosunu Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    Console.WriteLine("---------------------------------------------------------");
            //    foreach (var item in row.ItemArray)
            //    {

            //        Console.Write(item.ToString() + " ");

            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün Tablosunu Ürün Silme İşlemi

            //Console.Write("Silmek İstediğiniz Ürünün Idsini Giriniz: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine($"{productId} .idli Ürününüz Başarılı Bir Şekilde Silindi.");



            #endregion

            #region Ürün Tablosunda Ürün Günceleme İşlemi
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Güncellemek İstediğiniz Ürünün Idsini Giriniz: ");
            int productId=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Ürünün Adını Giriniz: ");
            string productName = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Ürünün Fiyatını Giriniz: ");
            decimal productPrice=decimal.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            connection.Open();
            SqlCommand commandUpdate = new SqlCommand("Update TblProduct Set  ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId", connection);
            commandUpdate.Parameters.AddWithValue("productId", productId);
            commandUpdate.Parameters.AddWithValue("productName", productName);
            commandUpdate.Parameters.AddWithValue("productPrice", productPrice);
            commandUpdate.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine($"{productId} .idli Ürününüz Yeni İsmi: {productName} Yeni Fiyatı: {productPrice} Olarak Başarılı Bir Şekilde Güncellendi.");


            #endregion

            Console.Read();
        }
}
}
