﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye Döndürmeyen Metotlar
            //Customer--> Listele, ekle , sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Furkan a");
            //    Console.WriteLine("Furkan b");
            //    Console.WriteLine("Furkan c");
            //    Console.WriteLine("Furkan d");
            //}
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
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Furkan Çelmeli");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + "" +surName);
            //}
            //CustomerCard("Furkan", " Çelmeli");
            //CustomerCard("Muhammet", " Çelmeli");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerNamer()
            //{
            //    return "Furkan Çelmeli";
            //}
            //CustomerNamer();

            //string StudentCard()
            //{
            //    string name = "Furkan";
            //    string surname = "Çelmeli";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor) 
            //{
            //    string cardInfo= "Ülke: "+ countryName + " - Başkent: " + capital + "-  Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //    int result= number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(65,45));
            //Console.WriteLine(Sum(21,15));
            //Console.WriteLine(Sum(68,99));
            #endregion


            #region ÖrnekUygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti" + " Ortalama: "+ result;
            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi" + " Ortalama: " + result;

            //    }
            //}

            //Console.WriteLine(ExamResult("Furkan", 45,68,85));
            //Console.WriteLine(ExamResult("Eda", 77,66,100));
            #endregion
            Console.Read();
        }

        
    }
    
}