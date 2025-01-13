using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanılı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            string TableNumber;
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz:");
            TableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J5TKTCT;initial Catalog=EgitimKampıDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("---------------------------------------------------------");
                foreach (var item in row.ItemArray)
                {

                    Console.Write(item.ToString() + " ");

                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine();
            }

        
        Console.Read();
        }
}
}
