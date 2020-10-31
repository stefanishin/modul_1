using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 5.Начальный вклад в банке равен 1000 руб. Через каждый месяц размер
//вклада увеличивается на P процентов от имеющейся суммы. По данному P
//определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести
//найденное количество месяцев K и итоговый размер вклада S.

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double kopc; int x;
            long grn, kop, m;

            do
            {
            m1: Console.WriteLine($"Коммерсант считает прибыль\nИтак, у него есть стартовый капитал, в гривнях");

                double k = double.Parse(Console.ReadLine());
                Console.WriteLine("Капитал будет ежемесячно увеличиваться на , процентов:");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine($"Капитал должен достигнуть суммы:");
                double s = double.Parse(Console.ReadLine()); m = 0;
                if (k == s && k != 0 && s != 0) { Console.WriteLine("\nКапитал равен необходимой сумме, жизнь удалась!"); }
                if (k > s)
                {
                    Console.WriteLine("\nКапитал больше необходимой суммы, банкомат в шоке!");
                    Console.ReadLine(); Console.Clear(); goto m1;
                }
                if (k <= 0 || p <= 0 || s < 0)
                {
                    Console.WriteLine("\nОкей, поигрались, а теперь давай реальные данные!");
                    Console.ReadLine(); Console.Clear(); goto m1;
                }
                while (k < s)
                {
                    m++;
                    k = k + k * p / 100;
                    grn = (long)k;
                    kopc = (k - grn) * 100;
                    kop = (long)kopc;
                    Console.Write($" {m} ");
                    if (m % 100 > 10 && m % 100 < 15) Console.Write($" месяцев");
                    else
                    {
                        switch (m % 10)
                        {
                            case 0: case 5: case 6: case 7: case 8: case 9: Console.Write($" месяцев"); break;
                            case 1: Console.Write($" месяц"); break;
                            case 2: case 3: case 4: Console.Write($" месяца"); break;
                        }
                    }
                    Console.Write($" = {grn}");

                    if (grn % 100 > 10 && grn % 100 < 15) Console.Write(" гривней");
                    else
                    {
                        switch (grn % 10)
                        {
                            case 0: case 5: case 6: case 7: case 8: case 9: Console.Write(" гривней"); break;
                            case 1: Console.Write(" гривнь"); break;
                            case 2: case 3: case 4: Console.Write(" гривня"); break;
                        }
                    }
                    Console.Write($" = {kop} ");

                    if (kop % 100 > 10 && kop % 100 < 15) Console.Write(" копеек\n");
                    else
                    {
                        switch (kop % 10)
                        {
                            case 0: case 5: case 6: case 7: case 8: case 9: Console.WriteLine(" копеек"); break;
                            case 1: Console.WriteLine(" копейка"); break;
                            case 2: case 3: case 4: Console.WriteLine(" копейки"); break;
                        }
                    }


                }
                Console.WriteLine($"\n\nТекущая сумма будет достигнута через {m} ");

                if (m % 100 > 10 && m % 100 < 15) Console.Write(" месяцев");
                else
                {
                    switch (m % 10)
                    {
                        case 0: case 5: case 6: case 7: case 8: case 9: Console.Write(" месяцев"); break;
                        case 1: Console.Write(" месяц"); break;
                        case 2: case 3: case 4: Console.Write(" месяцa"); break;
                    }
                }
                Console.WriteLine($"");
                Console.WriteLine("\nПрограмма была успешно выполнена. Желаете перезапустить? (1/0)");

                x = int.Parse(Console.ReadLine());
                Console.ReadLine(); Console.Clear();
            }
            while (x == 1);

        }
    }
}
