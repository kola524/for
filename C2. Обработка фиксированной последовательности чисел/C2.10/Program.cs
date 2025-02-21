using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка: введите число.");
                return;
            }

            double sum = x;
            double term = x; // Первое слагаемое x

            for (int i = 3; i <= 11; i += 2)
            {
                term *= x * x; // Умножаем на x^2 вместо Math.Pow
                sum += term / i;
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");
        }
    }
}
