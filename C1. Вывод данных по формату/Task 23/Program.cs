using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double x = 4.4; x <= 6.4; x += 0.1)
            {
                Console.WriteLine(x.ToString("F1"));
            }
        }
    }
}
