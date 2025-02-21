using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double x = 2.1; x <= 2.8; x += 0.1)
            {
                Console.WriteLine(x.ToString("F1"));
            }
        }
    }
}
