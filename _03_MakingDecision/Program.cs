using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifrenizi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifreniz Doğru");
            //}
            //else {
            //    Console.WriteLine("Girmiş Olduğunuz Şifre Hatalıdır!");
            //}

            //string capital, country;
            //Console.Write("Ülkenizin Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: "); 
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{ 
            //    Console.Write("Girmiş Olduğunuz Veriler Doğrulanmıştır");
            //}
            //else
            //{
            //Console.Write("Girmiş Olduğunuz Verilerin Hatalı Olduğu Tespit Edilmiştir!");
            //}

            //int number;
            //Console.WriteLine("Sayı Giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayınız Doğru");

            //}
            //else 
            //{
            //    Console.WriteLine("Sayınız Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata !";

            //Console.Write("1. Sınav: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavlarınızın Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Çok Kötü :( ";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Fena Değil ";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç Gayet İyi !";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Süper !";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen Bir Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "İstanbul" | city == "Aydın" | city == "Antalya" | city == "Muğla")
            //{
            //    Console.WriteLine("Yazdığınız Şehir Mevcuttur.");
            //}
            //else
            //{
            //    Console.WriteLine("Yazdığınız Şehir Maalesef Mevcut Değildir!");
            //}


            //Console.Write("Kullanıcı Adınızı Giriniz: ");
            //string userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı İle Giriş Yapamazsınız !");
            //}
            //else {
            //    Console.Write("Hoş Geldiniz :) ");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen İlk Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("İlk Sayının, İkinci Sayıya Bölümünden Kalan: " + result);

            //Console.Write("Lütfen Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Girdiğiniz Sayı Çifttir");
            //}
            //else 
            //{
            //    Console.Write("Sayınız Tektir");
            //}
            #endregion

            #region Char Değişkenleri İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takımınıızn Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("EN BÜYÜK BEŞİKTAŞ !");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine(" ****** C# Eğitim Kampı Restoran ****** ");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Ana Yemekler -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Köri Soslu Tavuk");
            //    Console.WriteLine("2-) Kızartma Tabağı");
            //    Console.WriteLine("3-) Adana Kebap");
            //    Console.WriteLine("4-) Sacda Gözleme");
            //    Console.WriteLine("5-) Güveç Karides");
            //    Console.WriteLine("----- Ana Yemekler -----");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Çorbalar -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Kellepaça Çorbası");
            //    Console.WriteLine("2-) Mercimek Çorbası");
            //    Console.WriteLine("3-) Ayranlı Çorba");
            //    Console.WriteLine("4-) Tarhana Çorbası");
            //    Console.WriteLine("5-) Tavuklu Çorba");
            //    Console.WriteLine("----- Çorbalar -----");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Pizzalar -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Akdeniz Pizzası");
            //    Console.WriteLine("2-) Margarita Pizzası");
            //    Console.WriteLine("3-) Hawaii Pizzası");
            //    Console.WriteLine("4-) Puglia Pizzası");
            //    Console.WriteLine("5-) Marinara Pizzası");
            //    Console.WriteLine("----- Pizzalar -----");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- İçecekler -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Kola");
            //    Console.WriteLine("2-) Ayran");
            //    Console.WriteLine("3-) Acılı Şalgam");
            //    Console.WriteLine("4-) Soda");
            //    Console.WriteLine("5-) Su");
            //    Console.WriteLine("----- İçecekler -----");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----- Tatlılar -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-) Trileçe");
            //    Console.WriteLine("2-) Fıstıklı Baklava");
            //    Console.WriteLine("3-) Saray Sarması");
            //    Console.WriteLine("4-) Profiterol");
            //    Console.WriteLine("5-) Şekerpare");
            //    Console.WriteLine("----- Tatlılar -----");

            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case 

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi 

            //int number1, number2, number3,result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol) 
            //{ 
            //case '+':
            //    result = number1 + number2;
            //    Console.WriteLine("Toplam: " + result);
            //    break;
            //case '-':
            //    result = number1 - number2;
            //    Console.WriteLine("Fark: " + result);
            //    break;
            //case '*':
            //      result = number1 * number2;
            //      Console.WriteLine("Çarpım: " + result);
            //      break;
            //case '/':
            //      result = number1 / number2;
            //      Console.WriteLine("Bölüm: " + result);
            //      break;
            //}

            #endregion

            Console.Read();
        }
    }
}
