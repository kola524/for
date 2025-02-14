using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Дюймы | Сантиметры |");
            Console.WriteLine("|-------|------------|");

            for (int inches = 10; inches <= 22; inches++)
            {
                double cm = inches * 2.54;
                Console.WriteLine($"| {inches,5} | {cm,10:F2} |");
            }
        }
    }
}
