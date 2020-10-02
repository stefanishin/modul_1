using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Дано значение температуры T в градусах Фаренгейта. 
 * Определить значение этой же температуры в градусах Цельсия. 
 * Температура по Цельсию TC и температура по Фаренгейту TF 
 * связаны следующим соотношением:
 * TC = (TF – 32)·5 / 9.
*/

namespace ConsoleAppTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter F: ");
            double T = double.Parse(Console.ReadLine());

            //int value = Convert.ToInt32(Console.ReadLine());
            //string str = Console.ReadLine();
            //int value = Convert.ToInt32(str);
            //int value = Convert.ToInt32(Console.ReadLine());

            double TC = Math.Round((T - 32) * 5 / 9);

            Console.WriteLine($"Temperature F : {TC}");
            // Console.ReadKey();
        }
    }
}
