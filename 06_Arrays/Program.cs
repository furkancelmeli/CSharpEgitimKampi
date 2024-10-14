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
            #region TemelDiziOrnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Sarı";
            //colors[3] = "Lacivert";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "İstanbul";
            //cities[2] = "Lyon";
            //cities[3] = "Paris";
            //cities[4] = "Madrid";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 77;
            //numbers[2] = 49;
            //numbers[3] = 111;
            //numbers[7] = 555;

            //Console.WriteLine(numbers[5]);


            //string[] cities = { "Prag", "Roma", "İstanbul", "Antalya" };

            //Console.WriteLine(cities[2]);




            #endregion



            #region DizidekiTumElemanlariListeleme

            //string[] colors = { "Sarı", "Lacivert", "Kırmızı", "Mavi", "Turuncu", "Pembe" };

            //for (int i = 0; i <colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 15, 64, 49436, 4813, 1546, 48432, 1764, };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '-', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 55, 8, 941, 254, 26, 487, 68, 497, 245 };

            //int maxNumber= myArray[0];

            //for(int i = 0; i<myArray.Length;i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "furkan", "ahmet", "cem", "murat" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 2, 4616, 17, 64, 25, 489 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 1, 2, 4616, 17, 64, 25, 489 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion


            #region DiziMetodalari

            //string[] customers = { "furkan", "eda", "mehmet", "ali", "fatih" };
            //int index = Array.IndexOf(customers, "fatih");
            //Console.WriteLine(index);

            //int[] numbers = { 15, 46, 1614, 248, 12, 6489, 124 };
            //Console.WriteLine("Dizinin En Büyük Eleman: "+numbers.Max()+ " Dizinin En Küçük Elemanı: "+numbers.Min());




            #endregion

            #region KullanicidanDegerAlma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 1, 2, 10, 23, 45, 66, 454 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            int[] numbers = { 31, 42, 33, 45, 56, 632, 731, 38, 89 };
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("----------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

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
