using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace б
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a (0 < a <= 50): ");
            int a = int.Parse(Console.ReadLine());

            if (a <= 0 || a > 50)
            {
                Console.WriteLine("Ошибка: a должно быть в диапазоне (0, 50].");
                return;
            }

            int sum = 0;

            for (int i = a; i <= 50; i++)
            {
                sum += i * i;
            }

            Console.WriteLine($"Сумма квадратов всех целых чисел от {a} до 50: {sum}");
        }
    }
}
