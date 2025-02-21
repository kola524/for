using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x <= 20; x++)
            {
                Console.WriteLine($"sin({x}) = {Math.Sin(x):F6}");
            }
        }
    }
}
