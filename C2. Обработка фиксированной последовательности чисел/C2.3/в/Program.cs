using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace в
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a (a < 200): ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 200)
            {
                Console.WriteLine("Ошибка: a должно быть меньше 200.");
                return;
            }

            int sum = 0, count = 0;

            for (int i = a; i <= 200; i++, count++) sum += i;

            Console.WriteLine($"Среднее арифметическое: {(double)sum / count}");
        }
    }
}
