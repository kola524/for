using System;

class Program
{
    static void Main()
    {
        // a) Числа от 21 до 35 с дробной частью 20.4, 21.4 и т. д.
        Console.WriteLine("Числа от 21 до 35 с дробной частью:");
        for (int i = 21; i <= 35; i++)
        {
            Console.WriteLine(i + " " + (i - 0.6));
        }

        // б) Числа от 16 до 24 с дробными значениями
        Console.WriteLine("Числа от 16 до 24 с дробными значениями:");
        for (int i = 16; i <= 24; i++)
        {
            Console.WriteLine(i + " " + (i - 0.5) + " " + (i + 0.8));
        }
    }
}
