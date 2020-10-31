using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 Задание 4. Даны целые положительные числа A и B (A < B). Вывести все целые
числа от A до B включительно; каждое число должно выводиться на новой строке;
при этом каждое число должно выводиться количество раз, равное его значению.
Например: если А = 3, а В = 7, то программа должна сформировать в консоли
следующий вывод:*/
namespace ConsoleAppTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            int a, b;

            do
            {
                Console.WriteLine("Введите число: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число большее за предыдущее: ");
                b = int.Parse(Console.ReadLine());
                if (a < b) p = 1;
                else p = 0;
            } while (p == 0);

            Console.Clear();
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
