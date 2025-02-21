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
            Console.Write("Введите значение n (1 <= n <= 100): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                Console.WriteLine("Ошибка: n должно быть в диапазоне [1, 100].");
                return;
            }

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }

            Console.WriteLine($"Сумма квадратов всех целых чисел от 1 до {n}: {sum}");
        }
    }
}
