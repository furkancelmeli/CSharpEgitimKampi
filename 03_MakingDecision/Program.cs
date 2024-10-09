using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış!");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("verileri doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi!!");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış!");
            //}

            //double exam1, exam2, exam3, average;
            //string result= "Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması: " + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = " Sonuç Kötü ";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = " Sonuç Orta ";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " Sonuç İyi ";
            //}
            //if (average >= 85 & average <= 100)
            //{
            //    result = " Sonuç Çok iyi ";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana"| city == "ankara"| city=="istanbul"|city=="antalya")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username!= "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}




            #endregion

            #region ModIslemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2 sayıya bölümünden kalan: "+ result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number%2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region CharDegiskenlerIleKararYapılari
            //char team;
            //Console.Write("Lütfen takım semnölünü giriniz: ");
            //team= char.Parse(Console.ReadLine());

            //if(team =='f'|team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team =='g'|team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region OrnekProjeUygulamasi

            //Console.WriteLine("***** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğiniz menüyü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Kuru Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Tavuk Çorbası");
            //    Console.WriteLine("4-Domates Çorbası");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İçecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();

            //}
            #endregion

            #region SwitchCase

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak");break;
            //    case 2: Console.WriteLine("Şubat");break;
            //    case 3: Console.WriteLine("Mart");break;
            //    case 4: Console.WriteLine("Nisan");break;
            //    case 5: Console.WriteLine("Mayıs");break;
            //    case 6: Console.WriteLine("Haziran");break;
            //    case 7: Console.WriteLine("Temmuz");break;
            //    case 8: Console.WriteLine("Ağustos");break;
            //    case 9: Console.WriteLine("Eylül");break;
            //    case 10: Console.WriteLine("Ekim");break;
            //    case 11: Console.WriteLine("Kasım");break;
            //    case 12: Console.WriteLine("Aralık");break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;



            #endregion

            #region HesapMakinasi

            int number1, number2,result;
            char symbol;
            Console.Write("1. Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result=number1+ number2;
                    Console.WriteLine("Toplam: "+result);
                    break;
                case '-':
                    result=number1- number2;
                    Console.WriteLine("Çıkarma: " + result);

                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpma: " + result);

                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölme: " + result);

                    break;
                
            }


            #endregion

            Console.Read();
        }
    }
}
