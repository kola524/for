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
            Console.Write("Введите число a (a < 500): ");
            if (int.TryParse(Console.ReadLine(), out int a) && a < 500)
            {
                int sum = 0;
                for (int i = a; i <= 500; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Сумма всех целых чисел от {a} до 500: {sum}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число меньше 500.");
            }
        }
    }
}
