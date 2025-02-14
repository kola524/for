using System;

class Program
{
    static void Main()
    {
        // a) Числа от 10 до 25 с дробной частью 0.4
        Console.WriteLine("Числа от 10 до 25 с дробной частью 0.4:");
        for (int i = 10; i <= 25; i++)
        {
            Console.WriteLine(i + " " + (i + 0.4));
        }

        // б) Числа от 25 до 35 с дробными значениями
        Console.WriteLine("Числа от 25 до 35 с дробными значениями:");
        for (int i = 25; i <= 35; i++)
        {
            Console.WriteLine(i + " " + (i + 0.5) + " " + (i - 0.2));
        }
    }
}
