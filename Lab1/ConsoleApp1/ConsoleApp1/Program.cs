using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Задание 1.Дано значение температуры T в градусах Фаренгейта. Определить
            ////значение этой же температуры в градусах Цельсия. Температура по Цельсию TC
            ////и температура по Фаренгейту TF связаны следующим соотношением:
            ////TC = (TF – 32)·5 / 9.

            //Console.Write("Enter F: ");
            //int T = int.Parse(Console.ReadLine());

            //int value = Convert.ToInt32(Console.ReadLine());
            //string str = Console.ReadLine();
            //int value = Convert.ToInt32(str);
            //int value = Convert.ToInt32(Console.ReadLine());

            //int TC = (T - 32) * 5 / 9;
            //Console.WriteLine($"Temperature F : {TC}");
            //Console.ReadKey();

            ////Задание 2.Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
            ////Найти его периметр и площадь

            ////Для нахождения площади треугольника со сторонами a, b, c использовать
            ////формулу Герона:
            ////S = (p·(p – a)·(p – b)·(p – c))1 / 2,
            ////где p = (a + b + c) / 2 — полупериметр.

            //Console.Write("Enter x1: ");
            //int x1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter y1: ");
            //int y1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //int x2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter y2: ");
            //int y2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //int x3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter y3: ");
            //int y3 = Convert.ToInt32(Console.ReadLine());

            //double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //Вичисляем по формуле сторону а
            //double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); //Вичисляем по формуле сторону b
            //double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)); //Вичисляем по формуле сторону c

            //Console.WriteLine($"a = {a} \n b = {b} \n c = {c}");

            //double p = (a + b + c) / 2; //вычисляем  полупериметр
            //double P = p * 2; // вычисляем периметр 
            //double S = Math.Pow(p * (p - a) * (p - b) * (p - c), 1.0 / 2.0); //Формула Герона            
            //Console.Write($"P={P} \n S={S}");
            //Console.ReadKey();

            ////Задание 3.Дано целое число в диапазоне 100–999.Вывести строку - описание
            ////данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот
            ////четырнадцать».

            //   Преобразует указанное строковое представление числа в эквивалентное 32 - битовое целое число со знаком.
            //  int n = Convert.ToInt32(s);
            //int z;
            //do
            //{
            //    Console.Write("Enter N: ");
            //    int n = int.Parse(Console.ReadLine());
            //    while (n < 100 || n > 999)
            //    {
            //        Console.Write($"Error! Число должно быть в диапозоне 100-999, {n}");
            //        Console.Write($"\nEnter N: ");
            //        n = int.Parse(Console.ReadLine());
            //    }


            //    string s = null;

            //    int d = n / 100; // сотни
            //    int d1 = n % 100;//остатки
            //    int s = d1 / 10;// десятки
            //    int e = d1 % 10;//единицы

            //    switch (d)
            //    {
            //        case 1: Console.WriteLine($"сто"); break;
            //        case 2: Console.WriteLine($"двести"); break;
            //        case 3: Console.WriteLine($"триста"); break;
            //        case 4: Console.WriteLine($"четыреста"); break;
            //        case 5: Console.WriteLine($"пятьсот"); break;
            //        case 6: Console.WriteLine($"шестьсот"); break;
            //        case 7: Console.WriteLine($"семьсот"); break;
            //        case 8: Console.WriteLine($"восемьсот"); break;
            //        case 9: Console.WriteLine($"девятьсот"); break;
            //    }
            //    switch (s)
            //    {
            //        case 1: Console.WriteLine($"десять"); break;
            //        case 2: Console.WriteLine($"двадцать"); break;
            //        case 3: Console.WriteLine($"тридцать"); break;
            //        case 4: Console.WriteLine($"сорок"); break;
            //        case 5: Console.WriteLine($"пятьдесят"); break;
            //        case 6: Console.WriteLine($"шестьдесят"); break;
            //        case 7: Console.WriteLine($"семдесят"); break;
            //        case 8: Console.WriteLine($"восемдесят"); break;
            //        case 9: Console.WriteLine($"девяносто"); break;
            //    }

            //    switch (e)
            //    {
            //        case 1: Console.WriteLine($"один"); break;
            //        case 2: Console.WriteLine($"два"); break;
            //        case 3: Console.WriteLine($"три"); break;
            //        case 4: Console.WriteLine($"четыре"); break;
            //        case 5: Console.WriteLine($"пять"); break;
            //        case 6: Console.WriteLine($"шесть"); break;
            //        case 7: Console.WriteLine($"семь"); break;
            //        case 8: Console.WriteLine($"восемь"); break;
            //        case 9: Console.WriteLine($"девять"); break;
            //    }

            //    Console.WriteLine($"One more?(1-yes,0-no) ");
            //    z = int.Parse(Console.ReadLine());
            //}
            //while (z == 1);

            //-----
            // Задание 4. Даны целые положительные числа A, B, C. 
            //Значение этих чисел программа должна запрашивать у пользователя.
            //На прямоугольнике размера A *B размещено максимально возможное количество квадратов со стороной C.
            //Квадраты не накладываются друг на друга. Найти количество квадратов,размещенных на прямоугольнике, 
            //а также площадь незанятой части прямоугольника.
            //Необходимо предусмотреть служебные сообщения в случае, 
            //если в прямоугольнике нельзя разместить ни одного квадрата со стороной С.


            //Console.WriteLine("Enter А: ");
            //int A = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter B: ");
            //int B = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter C: ");
            //int C = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine(" Значения  больше данных - ");
            //    Console.WriteLine("Enter А: ");
            //    A = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter B: ");
            //    B = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter C: ");
            //    C = int.Parse(Console.ReadLine());
            //} while (C > A || C > B);

            //int d1 = A / C;
            //int d2 = B / C;
            //int kl = d1 * d2;// количество прямоугольничков
            //int S = B * (A % C) + A * (B % C); //свободная площадь прямоугольника
            //Console.WriteLine($"Количество прямоугольничков - {kl} ");
            //Console.WriteLine($"Свободная площадь прямоугольника - {S}");
            //Console.ReadKey();

            //---
            //Задание 5. Начальный вклад в банке равен 1000 руб.Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы.
            //По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести
            //найденное количество месяцев K и итоговый размер вклада S.

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



