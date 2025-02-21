using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace г
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b (b > a): ");
            int b = int.Parse(Console.ReadLine());

            if (b <= a)
            {
                Console.WriteLine("Ошибка: b должно быть больше a.");
                return;
            }

            int sum = 0, count = 0;

            for (int i = a; i <= b; i++, count++) sum += i;

            Console.WriteLine($"Среднее арифметическое: {(double)sum / count}");
        }
    }
}
