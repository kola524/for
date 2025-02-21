using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 1.0, term = 1.0;

            for (int i = 1; i <= 8; i++)
            {
                term /= 3; 
                sum += term;
            }

            Console.WriteLine($"Сумма ряда: {sum}");
        }
    }
}
