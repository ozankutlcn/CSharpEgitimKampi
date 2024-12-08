using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRUD->Create,Read,Update,Delete
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=Ozan; initial catalog=EgitimKampiDB; integrated security=true");
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", sqlConnection);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi!");

            //-------------------------------------------------------------------------------------------------------------------------------------------

            //Console.WriteLine("***** Ürün Giriş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------");

            //Console.WriteLine("Eklemek İstediğiniz Ürünün Adını Giriniz");
            //string productName = Console.ReadLine();

            //Console.WriteLine("Eklemek İstediğiniz Ürünün Fiyatını Giriniz");
            //double productPrice = double.Parse(Console.ReadLine());

            //Console.WriteLine("Eklemek İstediğiniz Ürünün Statüsünü Giriniz");
            //bool productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source=Ozan; initial catalog=EgitimKampiDB; integrated security=true");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@p1", productName);
            //sqlCommand.Parameters.AddWithValue("@p2", productPrice);
            //sqlCommand.Parameters.AddWithValue("@p3", productStatus);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Ürün Başarıyla Eklendi!");

            //-------------------------------------------------------------------------------------------------------------------------------------------


            //Console.WriteLine("***** Lütfen Silmek İstediğiniz Ürünün ID'sini Yazınız *****");
            //Console.WriteLine("");

            //int deleteProduct = int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source=Ozan; initial catalog=EgitimKampiDB; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductID=@productId", conn);
            //cmd.Parameters.AddWithValue("@productId", deleteProduct);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Ürününüz Başarıyla Silinmiştir !");

            //Console.Read();

            //-------------------------------------------------------------------------------------------------------------------------------------------

            //Console.WriteLine("***** Güncellemek İstediğiniz Ürünün IDsini Yazınız *****");
            //int productId = int.Parse(Console.ReadLine());

            //Console.WriteLine("***** Güncellemek İstediğiniz Ürünün Adını Yazınız *****");
            //string productName = Console.ReadLine();

            //Console.WriteLine("***** Güncellemek İstediğiniz Ürünün Fiyatını Yazınız *****");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //SqlConnection sqlConnection = new SqlConnection("Data Source=Ozan; initial catalog=EgitimKampiDB; integrated security=true");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId",sqlConnection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //sqlConnection.Close();
            //Console.WriteLine("Güncelleme Başarılı !");
            Console.Read();
        }
    }
}
