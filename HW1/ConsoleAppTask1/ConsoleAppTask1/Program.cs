using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Задание 1.
Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
Программа должна сосчитать количество введенных пользователем пробелов.
 */
namespace ConsoleAppTask1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            char symbol;
            Console.WriteLine("Программа для подсчета пробелов! ");
            int k = 0;
            do
            {
                Console.WriteLine("введите последовательность символ");
                Console.WriteLine("Нажмите кнопку точку,  для выхода из циклов");
                symbol = Console.ReadKey().KeyChar;                
                Console.Clear();

                Console.WriteLine(symbol);
                if (symbol == ' ')
                {
                    k++;
                    Console.WriteLine("Пробел");                    
                    Console.WriteLine($"Количество введенных пробелов = {k}");
                }
                
            } while (symbol != '.');
            Console.WriteLine($"Kоличество пробелов: {k}");
        }
    }
}
