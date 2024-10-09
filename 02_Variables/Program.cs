using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDegiskenler
            ////double number;

            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.85;
            //strawberryPrice = 10.50;
            //potatoPrice = 7.57;
            //tomatoPrice = 12.45;

            //Console.WriteLine("---- Elma birim fiyatı: "+ applePrice+ " TL");
            //Console.WriteLine("---- Çilek birim fiyatı: "+ strawberryPrice+" TL");
            //Console.WriteLine("---- Portakal birim fiyatı: " + orangePrice +  " TL");
            //Console.WriteLine("---- Patates birim fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates birim fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.300;
            //strawberryGram = 0.345;
            //potatoGram = 0.750;
            //tomatoGram = 3.456;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma - "+"Birim Fiyat: "+ applePrice+"- Gramaj:"+appleGram+ "- Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - "+"Birim Fiyat: "+ orangePrice+"- Gramaj:"+orangeGram+ "- Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - "+"Birim Fiyat: "+ strawberryPrice+"- Gramaj:"+strawberryGram+ "- Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - "+"Birim Fiyat: "+ potatoPrice+"- Gramaj:"+potatoGram+ "- Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - "+"Birim Fiyat: "+ tomatoPrice+"- Gramaj:"+tomatoGram+ "- Toplam Tutar: "+tomatoTotalPrice);

            //double shoopingTotalPrice=appleTotalPrice+ orangeTotalPrice+strawberryTotalPrice+tomatoTotalPrice+strawberryTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar" + shoopingTotalPrice + "TL");

            #endregion

            #region CharDegiskenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region KlavyedenVeriGirisleri

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

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+passengerIdentityNumber+" Yolcu Ad Soyad: "+ passengerName+" "+passengerSurname+" "+passengerDistrict+" / "+passengerCity+" "+passengerAge+" ");

            #endregion

            #region KlavyedenTamSayiGirisleriVeDönüsümler

            //int shoesPrices, computerPrice, chairPrice, tvPrice;
            //shoesPrices = 1000;
            //computerPrice = 20000;
            //chairPrice = 500;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount,tvCount ;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount*shoesPrices+ computerPrice* computerCount+ chairPrice* chairCount+tvPrice* tvCount;
            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödenemniz gereken tutar: "+totalPrice);

            #endregion

            #region KlavyedenOndalikliSayiIslemleri

            //double exam1,exam2,exam3, result ;
            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            
            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);


            #endregion


            #region KlavyedenKarakterGirisleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet "+gender);
            #endregion
            Console.Read();
        }
    }
}
