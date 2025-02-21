using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (n > 0): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ошибка: n должно быть больше 0.");
                return;
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");
        }
    }
}
