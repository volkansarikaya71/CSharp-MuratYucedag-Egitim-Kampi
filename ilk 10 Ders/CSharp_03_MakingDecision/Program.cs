﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else Kontrol Blogu
            //string password;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Şifre Giriniz: ");
            //password = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Şifre Doğru.");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Şifre Yanlış");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}

            //string capital, country;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Veriler Doğru.");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Hatalı Bilgi");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}

            //int number;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //if (number == 5)
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Sayı Doğru.");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Sayı Hatalı");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("1.ci Sınav Notunuzu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("2.ci Sınav Notunuzu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("3.cü Sınav Notunuzu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //average = (exam1 + exam2 + exam3) / 3;

            //    if (average >= 0 & average <= 50)
            //    {
            //        result = " Ortalamanız: " + average + " Sonuç Vasat. ";
            //    }
            //    if (average >= 50 & average <= 70)
            //    {
            //        result = " Ortalamanız: " + average + " Sonuç Orta. ";
            //    }
            //    if (average >= 70 & average <= 84)
            //    {
            //        result = " Ortalamanız: " + average + " Sonuç İyi. ";
            //    }
            //    if (average >= 84 & average <= 100)
            //    {
            //        result = " Ortalamanız: " + average + " Sonuç Çok İyi. ";
            //    }
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine(result);
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();



            //string city;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Şehir Mevcuttur ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Şehir Mevcut Değildir. ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}

            //string username;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            //username = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez! ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Hoşgeldiniz :) ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}




            #endregion
            #region Mod İşlemleri
            //int number,result;
            //number = 26;
            //result = number % 5;

            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("Sonuç: "+ result);
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();



            //int number1, number2, result;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen 1.inci Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen 2.inci Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //result = number1 % number2;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine("1.inci Sayının 2.nci Sayıya Bölümünden Kalan: " + result);
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();


            //int number;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();


            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine(number + " Sayısı Çift Bir Sayıdır. ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine(number + " Sayısı Tek Bir Sayıdır. ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            #endregion
            #region Char Değişkenleri İle Karar Yapıları
            //char team;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Takım Sembolünüzü Giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //if (team == 'g' | team == 'G')
            //{

            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Seçilen Takım: GALATASARAY");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}

            //if (team == 'f' | team == 'F')
            //{

            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Seçilen Takım: FENERBAHÇE");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}

            //if (team == 'b' | team == 'B')
            //{

            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine("Seçilen Takım: BEŞİKTAŞ");
            //    Console.WriteLine("------------------------------------------------------------------------------");
            //    Console.WriteLine();
            //}
            #endregion
            #region Örnek Proje Uygulaması 
            //string menuItem;
            //Console.WriteLine("***** C# Restoran Menüsü *****");
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Detaylarını Görmek İstediğiniz Menüyü Seçiniz: ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Kelle Paça Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizzası");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //}




            #endregion
            #region Switch Case

            //int mounthNumber;
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //mounthNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------------------------------------");
            //Console.WriteLine();
            //switch (mounthNumber)
            //{
            //    case 1: Console.Write("Ocak Ayını Seçtiniz"); break;
            //    case 2: Console.Write("Şubat Ayını Seçtiniz"); break;
            //    case 3: Console.Write("Mart Ayını Seçtiniz"); break;
            //    case 4: Console.Write("Nisan Ayını Seçtiniz"); break;
            //    case 5: Console.Write("Mayıs Ayını Seçtiniz"); break;
            //    case 6: Console.Write("Haziran Ayını Seçtiniz"); break;
            //    case 7: Console.Write("Temmuz Ayını Seçtiniz"); break;
            //    case 8: Console.Write("Ağustos Ayını Seçtiniz"); break;
            //    case 9: Console.Write("Eylül Ayını Seçtiniz"); break;
            //    case 10: Console.Write("Ekim Ayını Seçtiniz"); break;
            //    case 11: Console.Write("Kasım Ayını Seçtiniz"); break;
            //    case 12: Console.Write("Aralık Ayını Seçtiniz"); break;
            //    default: Console.Write("Hatalı Seçim Yaptınız"); break;
            //}


            #endregion
            #region Switch Case İle Hesap Makinesi Yapımı

            int number1, number2, result;
            char sembol;

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.Write("1.inci Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.Write("2.inci Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.Write("Lütfen Yapmak İsteğiniz İşlemi Giriniz: ");
            sembol = char.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            switch (sembol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("1.inci Sayının 2.nci Sayı İle Toplamı: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write("1.inci Sayının 2.nci Sayı İle Arasındaki Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write("1.inci ve 2.nci Sayının Çarpımı: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.Write("1.inci Sayının 2.nci Sayıya Bölümü: " + result);
                    break;

                default: Console.Write("Hatalı Seçim Yaptınız"); break;
            }
            #endregion
            Console.Read();
        }
    }
}
