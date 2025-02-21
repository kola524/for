using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 20; i <= 40; i++)
            {
                sum += i * i * i;
            }

            Console.WriteLine($"Сумма кубов всех целых чисел от 20 до 40: {sum}");
        }
    }
}
