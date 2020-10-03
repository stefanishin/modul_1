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
            string s = "hell ";
            //   Console.WriteLine($"{s}");

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            //Преобразует указанное строковое представление числа в эквивалентное 32-битовое целое число со знаком.
            // int n = Convert.ToInt32(s);
            do
            {
                if (n < 100 || n > 999) { Console.WriteLine($"Error! Число должно быть в диапозоне 100-999, {n}"); }
                Console.Write("Enter N: ");
                //  n = Convert.ToInt32(s);
                int n = int.Parse(Console.ReadLine());

            } while (n > 100 || n < 999);

            int n1 = n / 100; // сотни
            int n2 = n / 10 % 10; //десятки
            int n3 = n % 10; //единицы

            switch (n1)
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
                default: Console.WriteLine($"Введите правильно число"); break;
            }

            Console.ReadKey();
        }
    }
}
