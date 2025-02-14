using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                for (int i = 1; i <= 9; i++)
                    Console.WriteLine($"{i} x {num} = {i * num}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}
