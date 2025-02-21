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
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b (b > a): ");
            int b = int.Parse(Console.ReadLine());

            if (b <= a)
            {
                Console.WriteLine("Ошибка: b должно быть больше a.");
                return;
            }

            long product = 1; // Используем long для больших значений

            for (int i = a; i <= b; i++)
            {
                // Проверка на переполнение
                if (product > long.MaxValue / i)
                {
                    Console.WriteLine("Ошибка: Переполнение типа long!");
                    return;
                }

                product *= i;
            }

            Console.WriteLine($"Произведение всех целых чисел от {a} до {b} равно {product}");
        }
    }
}
