using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double R = 6370; // Радиус Земли в километрах

            Console.WriteLine("| Высота (км) | Горизонт (км) |");
            Console.WriteLine("|-------------|--------------|");

            for (int h = 1; h <= 10; h++)
            {
                double d = Math.Sqrt((R + h) * (R + h) - R * R);
                Console.WriteLine($"| {h,11} | {d,12:F2} |");
            }
        }
    }
}
