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
            for (int i = 100; i <= 500; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма всех целых чисел от 100 до 500: {sum}");
        }
    }
}
