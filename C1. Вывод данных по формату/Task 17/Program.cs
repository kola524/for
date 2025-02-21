using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double x = 0.1; x <= 1.6; x += 0.1)
            {
                Console.WriteLine($"sin({x:F1}) = {Math.Sin(x):F6}");
            }
        }
    }
}
