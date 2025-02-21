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
            Console.Write("Введите число b (b > -10): ");
            if (int.TryParse(Console.ReadLine(), out int b) && b > -10)
            {
                int sum = 0;
                for (int i = -10; i <= b; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Сумма всех целых чисел от -10 до {b}: {sum}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число больше -10.");
            }
        }
    }
}
