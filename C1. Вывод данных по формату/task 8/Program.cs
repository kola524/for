using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вес (фунты) | Вес (кг)");
            Console.WriteLine("--------------------");

            for (int pounds = 1; pounds <= 10; pounds++)
            {
                double kilograms = pounds * 0.453;
                Console.WriteLine($"{pounds,10} | {kilograms,8:F3}");
            }
        }
    }
}
