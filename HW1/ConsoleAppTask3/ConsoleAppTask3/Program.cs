using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Задание 3. 
Числовые значения символов нижнего регистра в коде ASCII 
отличаются от значений символов верхнего регистра на величину 32.
Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует
все символы нижнего регистра в символы верхнего регистра и наоборот
 */
//таблицы ASCII
//http://www.asciitable.com/
namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {           
            ConsoleKeyInfo s;
            do
            {
                Console.WriteLine(" Введите символ для конвертации регистратора ");
                Console.WriteLine("Конец ввода - ESC");
                s = Console.ReadKey();
                Console.WriteLine();

                Console.WriteLine("Введенный символ - " + s.KeyChar);
                if (char.IsLetter(Convert.ToChar(s.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(s.KeyChar)))
                    {
                        Console.WriteLine("Конвертируемый символ - " + char.ToLower(Convert.ToChar(s.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Конвертируемый символ - " + char.ToUpper(Convert.ToChar(s.KeyChar)));
                    }
                }
                if (Convert.ToInt32(s.KeyChar) == 28)
                {
                    break;
                }
            } while (true);
        }
    }
}
