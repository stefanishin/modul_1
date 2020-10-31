using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask5
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите N");
            string N = Console.ReadLine();
            if (Convert.ToInt64(N) < 0)
            {
                Console.WriteLine("Не соблюдено условие N>0");
 
            }

            Console.WriteLine("Полученное число");
            for (int i = N.Length - 1; i >= 0; i--)
            {
                Console.Write(N[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
