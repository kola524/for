using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кг конфет: ");
            if (double.TryParse(Console.ReadLine(), out double pricePerKg) && pricePerKg > 0)
            {
                Console.WriteLine("\nВес (г)  | Цена (тнг)");
                Console.WriteLine("---------------------");

                for (int weight = 100; weight <= 2000; weight += 100)
                {
                    double cost = (pricePerKg / 1000) * weight;
                    Console.WriteLine($"{weight,6}  | {cost,10:F2}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректную цену.");
            }
        }
    }
}
