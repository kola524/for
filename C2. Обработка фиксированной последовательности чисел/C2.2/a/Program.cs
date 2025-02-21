using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long product = 1; // Используем long, чтобы избежать переполнения
            for (int i = 8; i <= 15; i++)
            {
                product *= i;
            }
            Console.WriteLine($"Произведение всех целых чисел от 8 до 15: {product}");
        }
    }
}
