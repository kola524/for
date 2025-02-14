using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текущий курс доллара к рублю: ");
            if (double.TryParse(Console.ReadLine(), out double exchangeRate) && exchangeRate > 0)
            {
                Console.WriteLine("\n| Доллары |  Рубли  |");
                Console.WriteLine("|---------|--------|");

                for (int dollars = 1; dollars <= 20; dollars++)
                {
                    double rubles = dollars * exchangeRate;
                    Console.WriteLine($"| {dollars,7} | {rubles,7:F2} |");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное положительное число.");
            }
        }
    }
}
