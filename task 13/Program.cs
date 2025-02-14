using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int number = 7; // Число для умножения

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}"); // Используем x вместо ×
            }
        }
    }
}
