using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace а
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Crazy men";
            double s = 1;
            double r = 1;
            double z = 1;
            for (int j = 2; j < 101; j++)
            {
                z = -z;
                r += z / j;
                s += 1.0 / j;
            }
            string p = String.Format("{0:f3}", s) + " км ";
            Console.Write("Странный муж: пройденный путь - " + p);
            p = String.Format("{0:f3}", r) + " км";
            Console.WriteLine(", расстояние от дома - " + p);
            Console.ReadKey();
        }
    }
}
