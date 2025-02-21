using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 2; i <= 10; i++)
            {
                sum += (double)i / (i + 1);
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");
        }
    }
}
