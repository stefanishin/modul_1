using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
Найти его периметр и площадь (Формула Герона -Heron's formula)
 */
namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //Вичисляем по формуле сторону а
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); //Вичисляем по формуле сторону b
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)); //Вичисляем по формуле сторону c

            Console.WriteLine($"a = {a} \n b = {b} \n c = {c}");

            double p = (a + b + c) / 2; //вычисляем  полупериметр
            double P = p * 2; // вычисляем периметр 
            double S = Math.Pow(p * (p - a) * (p - b) * (p - c), 1.0 / 2.0); //Формула Герона            
            Console.Write($"P={P} \n S={S:f2}");
            Console.ReadKey();
        }
    }
}
