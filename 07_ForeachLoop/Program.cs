using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "İstanbul", "Paris", "Berlin", "Kopenhag", "Los Angeles","Budapeşte" };

            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = {843,23,675,38,25,82,58,97,247,427,58,7 };

            //Array.Sort(numbers); //Sort denemesi yaptım.

            //foreach (int nmbr in numbers) 
            //{
            //    Console.WriteLine(nmbr);
            //}

            //int[] numbers = { 843, 23, 675, 38, 25, 82, 58, 97, 247, 427, 58, 7 };

            //foreach (int num in numbers) 
            //{
            //    if (num % 2 == 0) 
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int[] numbers = { 843, 23, 675, 38, 25, 82, 58, 97, 247, 427, 58, 7 };

            //int total = 0;

            //foreach (int nmb in numbers) 
            //{
            //    total += nmb;
            //}
            //Console.WriteLine("Dizilerin Elemanlarının Toplamı: " + total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int nmb in numbers) 
            //{
            //    Console.WriteLine(nmb);
            //}

            //string word = "Selam";

            //foreach (char c in word) 
            //{ 
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kamp Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            //Öğrenci isim ve not ortalamalarının saklanacak diziler
            string[] studentNames = new string[studentCount]; //Dizinin eleman sayısı studentCount'a göre belirlenecek
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i<studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Notunu Giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            Console.WriteLine();
           //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine("--------------------------------------");

                Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması: {studentExamAvg[i]}" );

                if (studentExamAvg[i] < 50) //Kendim yaptım, dersten farklı olan tek kısım.
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Sınavı Geçememiştir ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Sınavı Başarıyla Geçmiştir ");
                }

                Console.WriteLine("--------------------------------------");
            }

            //Öğrencilerin ortalamaısının geçip ve kalma durumları

            #endregion

            Console.Read();
        }
    }
}
