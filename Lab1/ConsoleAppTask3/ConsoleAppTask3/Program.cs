using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Задание 3.Дано целое число в диапазоне 100–999.Вывести строку - описание
////данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот
////четырнадцать».
namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            do
            {
                Console.Write("Enter N: ");
                int n = int.Parse(Console.ReadLine());
                while (n < 100 || n > 999)
                {
                    Console.Write($"Error! Число должно быть в диапозоне 100-999, {n}");
                    Console.Write($"\nEnter N: ");
                    n = int.Parse(Console.ReadLine());
                }


                //string s = null;

                int d = n / 100; // сотни
                int d1 = n % 100;//остатки
                int s = d1 / 10;// десятки
                int e = d1 % 10;//единицы

                switch (d)
                {
                    case 1: Console.WriteLine($"сто"); break;
                    case 2: Console.WriteLine($"двести"); break;
                    case 3: Console.WriteLine($"триста"); break;
                    case 4: Console.WriteLine($"четыреста"); break;
                    case 5: Console.WriteLine($"пятьсот"); break;
                    case 6: Console.WriteLine($"шестьсот"); break;
                    case 7: Console.WriteLine($"семьсот"); break;
                    case 8: Console.WriteLine($"восемьсот"); break;
                    case 9: Console.WriteLine($"девятьсот"); break;
                }
                switch (s)
                {
                    case 1: Console.WriteLine($"десять"); break;
                    case 2: Console.WriteLine($"двадцать"); break;
                    case 3: Console.WriteLine($"тридцать"); break;
                    case 4: Console.WriteLine($"сорок"); break;
                    case 5: Console.WriteLine($"пятьдесят"); break;
                    case 6: Console.WriteLine($"шестьдесят"); break;
                    case 7: Console.WriteLine($"семдесят"); break;
                    case 8: Console.WriteLine($"восемдесят"); break;
                    case 9: Console.WriteLine($"девяносто"); break;
                }

                switch (e)
                {
                    case 1: Console.WriteLine($"один"); break;
                    case 2: Console.WriteLine($"два"); break;
                    case 3: Console.WriteLine($"три"); break;
                    case 4: Console.WriteLine($"четыре"); break;
                    case 5: Console.WriteLine($"пять"); break;
                    case 6: Console.WriteLine($"шесть"); break;
                    case 7: Console.WriteLine($"семь"); break;
                    case 8: Console.WriteLine($"восемь"); break;
                    case 9: Console.WriteLine($"девять"); break;
                }

                Console.WriteLine($"One more?(1-yes,0-no) ");
                z = int.Parse(Console.ReadLine());
            }
            while (z == 1);
        }
    }
}
