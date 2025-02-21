using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ошибка: n должно быть натуральным числом (n > 0).");
                return;
            }

            int sum = 0;

            for (int i = n; i <= 2 * n; i++)
            {
                sum += i * i;
            }

            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
