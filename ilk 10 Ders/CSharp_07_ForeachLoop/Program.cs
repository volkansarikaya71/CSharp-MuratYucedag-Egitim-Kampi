﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45,78,985,635,74,11,22,33,41,205,6578,10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number); 
            //    }

            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{ 
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char harf in word)
            //{
            //    Console.WriteLine(harf);
            //}


            #endregion
            #region Örnek Sınav Sistemi Uygulaması
            Console.WriteLine("***** C# Sınav Uygulaması *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrençi Bulunmaktadır: ");
            int StudentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            string[] StudentNames=new string[StudentCount];
            double[] StudentExamAvg=new double[StudentCount];

            for(int i=0;i<StudentCount;i++)
            {
                Console.Write($"{i+1}. Öğrencinin İsmini Giriniz: ");
                StudentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                for(int x=0;x<3;x++)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.Write($"{StudentNames[i]} Adlı Öğrencinin {x + 1}. Sınavından Aldığı Puanı Giriniz: ");
                    double value =double.Parse(Console.ReadLine());
                    totalExamResult += value;
                    Console.WriteLine("------------------------------------------------");
                }
                StudentExamAvg[i] = totalExamResult / 3;
            }

            Console.WriteLine();
            Console.WriteLine("Dersi Geçip Geçmeme Durumu");

            for (int i=0;i<StudentCount;i++)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"{StudentNames[i]} Adlı Öğrencinin Ortalaması: {StudentExamAvg[i]}");
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("***** C# Sınav Uygulaması *****");
            #endregion

            Console.Read();
        }
    }
}
