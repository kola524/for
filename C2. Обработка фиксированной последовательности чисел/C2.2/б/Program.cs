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
            Console.Write("Введите число a (1 ≤ a ≤ 20): ");
            if (int.TryParse(Console.ReadLine(), out int a) && a >= 1 && a <= 20)
            {
                long product = 1; // Используем long, чтобы избежать переполнения
                for (int i = a; i <= 20; i++)
                {
                    product *= i;
                }
                Console.WriteLine($"Произведение всех целых чисел от {a} до 20: {product}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число в диапазоне от 1 до 20.");
            }
        }
    }
}
