using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кг сыра: ");
            if (double.TryParse(Console.ReadLine(), out double pricePerKg) && pricePerKg > 0)
            {
                Console.WriteLine("\nВес (г)  | Цена (тнг)");
                Console.WriteLine("---------------------");

                for (int weight = 50; weight <= 1000; weight += 50)
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
