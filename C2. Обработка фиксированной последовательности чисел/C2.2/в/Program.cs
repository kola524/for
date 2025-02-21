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
            Console.Write("Введите значение b (1 <= b <= 20): ");
            int b = int.Parse(Console.ReadLine());

            if (b < 1 || b > 20)
            {
                Console.WriteLine("Ошибка: b должно быть в диапазоне от 1 до 20.");
                return;
            }

            long product = 1; // Используем long, чтобы избежать переполнения

            for (int i = 1; i <= b; i++)
            {
                product *= i;
            }

            Console.WriteLine($"Произведение всех целых чисел от 1 до {b} равно {product}");
        }
    }
}
