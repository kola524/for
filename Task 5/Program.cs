using System;

class Program
{
    static void Main()
    {
        // a) Числа от 21 до 10 с дробной частью 19.2, 18.2 и т. д.
        Console.WriteLine("Числа от 21 до 10 с дробной частью:");
        for (int i = 21; i >= 10; i--)
        {
            Console.WriteLine(i + " " + (i - 1.8));
        }

        // б) Числа от 45 до 25 с дробными значениями
        Console.WriteLine("Числа от 45 до 25 с дробными значениями:");
        for (int i = 45; i >= 25; i--)
        {
            Console.WriteLine(i + " " + (i - 0.5) + " " + (i - 0.8));
        }
    }
}
