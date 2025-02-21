using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace а
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1, an = 1000, n = 1000;

            // Вычисляем сумму арифметической прогрессии
            int sum = (n * (a1 + an)) / 2;

            // Среднее арифметическое
            double average = (double)sum / n;

            Console.WriteLine($"Среднее арифметическое всех целых чисел от 1 до 1000: {average}");
        }
    }
}
