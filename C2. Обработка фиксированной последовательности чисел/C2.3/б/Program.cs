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
            Console.Write("Введите значение b (b > 100): ");
            int b = int.Parse(Console.ReadLine());

            if (b <= 100)
            {
                Console.WriteLine("Ошибка: b должно быть больше 100.");
                return;
            }

            int sum = 0;
            int count = 0;

            // Цикл for для вычисления суммы и количества чисел
            for (int i = 100; i <= b; i++)
            {
                sum += i;
                count++;
            }

            // Вычисляем среднее арифметическое
            double average = (double)sum / count;

            Console.WriteLine($"Среднее арифметическое всех целых чисел от 100 до {b}: {average}");
        }
    }
}
