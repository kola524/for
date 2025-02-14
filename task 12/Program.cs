using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p0 = 1.29;        // Плотность воздуха у земли (кг/м³)
            const double z = 1.25e-4;      // Коэффициент экспоненциального затухания

            Console.WriteLine("| Высота (м) | Плотность (кг/м³) |");
            Console.WriteLine("|-----------|------------------|");

            for (int h = 0; h <= 1000; h += 100)
            {
                double p = p0 * Math.Exp(-h * z);
                Console.WriteLine($"| {h,9} | {p,16:F4} |");
            }
        }
    }
}
