using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (n > 0): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ошибка: введите натуральное число больше 0.");
                return;
            }

            double sum = 0;
            int sign = 1; // Начинаем с +1

            for (int i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / i);
                sign = -sign; // Меняем знак (+1 -> -1, -1 -> +1)
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");
        }
    }
}
