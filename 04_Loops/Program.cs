using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDongusu

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");
            //}

            //for (i = 3; i <=50; i +=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istedğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!!!");
            //}



            #endregion
            
            #region ForDongusuIleKararYapilari

            //for (i = 0; i <=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for ( i = 1; i<=10 ; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (i = 1; i <=20 ; i++)
            //{
            //    if (i % 2 ==0)
            //    {
            //        totalValue+= i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (i = 1; i <= 50; i++) 
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (i = 0; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium);
            //}
            #endregion

            #region WhileDongusu

            //int i = 0;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}



            #endregion


            #region OrnekSinavSorusu

            ////Klavyeden girilen3 basamaklı sayının basamaklı toplamını hesaplayan kodu yazın
            ////456
            //Console.Write("Sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100)/10;

            //Console.WriteLine(ones+"-"+tens+"-"+hundreds );
            //sum= ones+tens+hundreds;
            //Console.WriteLine(sum);
            #endregion
            Console.Read();
        }
    }
}
