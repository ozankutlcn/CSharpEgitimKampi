using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Siyah";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Berlin";
            //cities[4] = "Washington";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 88;
            //numbers[2] = 34;
            //numbers[3] = 2;
            //numbers[9] = 76;

            //Console.WriteLine(numbers[9]); //Indexe bir Değer ataması yapılmazsa o indexin değeri defaultta 0 olarak gelir.

            //string[] cities = { "Atina","Roma","Berlin","Kopenhag","Stockholm" };
            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki Tüm Elemanların Listelenmesi

            //string[] colors = { "Siyah","Beyaz","Mavi","Kırmızı","Turuncu","Yeşil" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 5,19,35,180,694,568,773,5680,4378 };

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0) 
            //    { 
            //        Console.WriteLine(numbers[i]);
            //    } 
            //}

            //char[] sembols = { 'B', 'E', 'Ş', 'İ', 'K', 'T', 'A', 'Ş' };
            //for (int i = 0; i < sembols.Length; i++) 
            //{
            //    Console.WriteLine(sembols[i]);
            //}

            //int[] myArray = {33,78,55,26,743,237,824,62,124 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber) 
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ozan","ömer","mira","deniz","eylül","bora" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = {10,58,853,4764,862,1275,94,28,57};
            //Array.Sort(numbers); //Diziyi sıralamaya yarar
            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 10, 58, 853, 4764, 862, 1275, 94, 28, 57 };
            //Array.Reverse(numbers); //Dizi tam tersine çevirir
            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Buse", "Mehtap", "Ali", "Cengiz", "Muhammer" };
            //int index = Array.IndexOf(customers,"Cengiz"); //IndexOf içerisine yazılan array elemanı kaçıncı index numarasına sahip olduğunu verir.
            //Console.WriteLine(index);

            //int[] numbers = {33,76,69,258,934,679,245,573,232 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "\nDizinin En Küçük Elemanı: " + numbers.Min()); //Max, dizinin en büyük elemanını,Min dizinin en küçük elemanını döndürür.



            #endregion

            #region Kullanıcıdan Değer Alma


            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10,20,43,76,132,964,48};
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = {31,52,36,47,52,66,74,87,99,670 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
