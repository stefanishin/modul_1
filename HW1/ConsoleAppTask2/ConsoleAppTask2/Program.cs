using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Задание 2.
Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано
шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
 */
namespace ConsoleAppTask2
{
    class Program
    {
        static void Main(string[] args)
        { int x;
			do
			{
				int a, c1, c2, c3, c4, c5, c6, ost;
				int p = 0;
				do
				{
					Console.WriteLine("Введите число: ");
					a = Convert.ToInt32(Console.ReadLine());
					//определение 1 цифры и проверка на ввод
					c1 = a / 100000;
					if ((c1 >= 1) && (c1 < 10))
					{
						Console.WriteLine("число  является шестизначным");
						p = 0;
					}
					else
					{
						Console.WriteLine("число не является шестизначным");
						p = 1;
					}
				} while (p == 1);

				//определение 2 - 6 цифр числа 
				ost = a % 100000;
				c2 = ost / 10000;
				ost = ost % 10000;
				c3 = ost / 1000;
				ost = ost % 1000;
				c4 = ost / 100;
				ost = ost % 100;
				c5 = ost / 10;
				c6 = ost % 10;
				// проверка на счастливость
				if ((c1 + c2 + c3) == (c4 + c5 + c6))
				{
					Console.WriteLine(a);
					Console.WriteLine("является счастливым ");
				}
				else
				{
					Console.WriteLine(a);
					Console.WriteLine("является  не счастливым ");
				}
				Console.WriteLine($"one more? 1/0");
				x = int.Parse(Console.ReadLine());
				Console.Clear();
			} while (x == 1);
		}
    }
}
