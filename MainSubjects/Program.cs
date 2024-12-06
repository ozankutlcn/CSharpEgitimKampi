using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.245;
            //strawberryGram = 1.245;
            //potatoGram = 1.245;
            //tomatoGram = 1.245;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma " + "\n-Birim Fiyat: " + applePrice + "\n-Gramaj: " + appleGram + "\n-Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("");

            //Console.WriteLine("Alınan Ürün: Portakal " + "\n-Birim Fiyat: " + orangePrice + "\n-Gramaj: " + orangeGram + "\n-Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("");

            //Console.WriteLine("Alınan Ürün: Çilek " + "\n-Birim Fiyat: " + strawberryPrice + "\n-Gramaj: " + strawberryGram + "\n-Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("");

            //Console.WriteLine("Alınan Ürün: Patates " + "\n-Birim Fiyat: " + potatoPrice + "\n-Gramaj: " + potatoGram + "\n-Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("");

            //Console.WriteLine("Alınan Ürün: Domates " + "\n-Birim Fiyat: " + tomatoPrice + "\n-Gramaj: " + tomatoGram + "\n-Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice);
            #endregion

            #region Char Değişkenler 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------------");

            //Console.WriteLine("Yolcu T.C. Kimlik No: " + passengerIdentityNumber + "\nYolcu: " + passengerName + " " + passengerSurname + "\nYolcu İlçe Bilgisi: " + passengerDistrict + "/" + passengerCity + "\nYolcu T.C. No: " + passengerIdentityNumber);


            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount , chairCount , tvCount;

            //Console.WriteLine("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Koltuk Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice; 

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            //Console.WriteLine();
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



            Console.Read();
        }
    }
}
