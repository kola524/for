using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pricePerItem = 55.99m;
            Console.WriteLine("Кол-во	Стоимость");
            for (int i = 2; i <= 20; i++)
            {
                decimal totalPrice = pricePerItem * i;
                Console.WriteLine($"{i}	{totalPrice:F2} руб.");
            }
        }
    }
}
