using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double x = 2.2; x <= 4.2; x += 0.1)
            {
                Console.WriteLine(x.ToString("F1"));
            }
        }
    }
}
