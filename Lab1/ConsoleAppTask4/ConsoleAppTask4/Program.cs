using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Задача 4
Даны целые положительные числа A, B, C. 
Значение этих чисел программа должна запрашивать у пользователя.
На прямоугольнике размера A * B размещено максимально возможное количество квадратов со стороной C.
Квадраты не накладываются друг на друга. 
Найти количество квадратов,размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.
Необходимо предусмотреть служебные сообщения в случае, 
если в прямоугольнике нельзя разместить ни одного квадрата со стороной С. 
 */
namespace ConsoleAppTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter А: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter C: ");
            int C = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(" Значения  больше данных - ");
                Console.WriteLine("Enter А: ");
                A = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter B: ");
                B = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter C: ");
                C = int.Parse(Console.ReadLine());
            } while (C > A || C > B);

            int d1 = A / C;
            int d2 = B / C;
            int kl = d1 * d2;// количество прямоугольничков
            int S = B * (A % C) + A * (B % C); //свободная площадь прямоугольника
            Console.WriteLine($"Количество прямоугольничков - {kl} ");
            Console.WriteLine($"Свободная площадь прямоугольника - {S}");
            Console.ReadKey();
        }
    }
}
