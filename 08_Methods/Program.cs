using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList() 
            //{
            //    Console.WriteLine("Ozan Kutlucan");
            //    Console.WriteLine("Sertap Erener");
            //    Console.WriteLine("Şebnem Ferah");
            //    Console.WriteLine("Hayko Cepkin");
            //    Console.WriteLine("Levent Yüksel");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum() 
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string CustomerName) 
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Ozan");

            //void CustomerCard(string name,string surname) 
            //{
            //    Console.WriteLine("Müşterinin Adı: " + name + "\nMüşterinin Soyadı: " + surname);
            //}
            //CustomerCard("Ozan","Kutlucan");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            // int result = number1 + number2 + number3;
            // Console.WriteLine(result);
            //}
            //Sum(1,2,3);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName() 
            //{
            //    return "Ozan Kutlucan";
            //}
            //CustomerName();

            //string StudentCard() 
            //{
            //    string name = "Sarp";
            //    string surname = "Akkaya";

            //    return name + " " + surname; 
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor) 
            //{
            //    string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nBayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}


            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Ülkenizin Başkentini Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine();
            //Console.WriteLine(CountryCard("Rusya","Moskova","Kırmızı-Mavi-Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2) 
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(23,54));
            //Console.WriteLine(Sum(53,86));
            //Console.WriteLine(Sum(24,64));

            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3) 
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " Adlı Öğrenci Sınavı Başarıyla Geçti= " + result;
                }
                else 
                {
                    return student + " Adlı Öğrenci Sınavı Geçemedi= " + result;
                }
            }

            Console.WriteLine(ExamResult("Ozan",80,70,74));
            #endregion


            Console.Read();
        }
    }
}
