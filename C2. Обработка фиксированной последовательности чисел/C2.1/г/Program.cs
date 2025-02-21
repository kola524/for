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
            Console.Write("Введите число a: ");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Write("Введите число b (b > a): ");
                if (int.TryParse(Console.ReadLine(), out int b) && b > a)
                {
                    int sum = 0;
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Сумма всех целых чисел от {a} до {b}: {sum}");
                }
                else
                {
                    Console.WriteLine("Ошибка: введите целое число b, которое больше a.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число a.");
            }
        }
    }
}
