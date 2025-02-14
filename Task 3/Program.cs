using System;

class Program
{
    static void Main()
    {
        // a) Все целые числа от 20 до 35
        Console.WriteLine("Числа от 20 до 35:");
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }
        // б) Квадраты всех целых чисел от 10 до b
        int b;
        for (; ; )
        {
            Console.Write("Введите значение b (b > 10): ");
            b = int.Parse(Console.ReadLine());
            if (b > 10) break;
        }
        Console.WriteLine("Квадраты чисел от 10 до " + b + ":");
        for (int i = 10; i <= b; i++)
        {
            Console.WriteLine(i * i);
        }
        // в) Третьи степени всех целых чисел от a до 50
        int a;
        for (; ; )
        {
            Console.Write("Введите значение a (a < 50): ");
            a = int.Parse(Console.ReadLine());
            if (a < 50) break;
        }

        Console.WriteLine("Третьи степени чисел от " + a + " до 50:");
        for (int i = a; i <= 50; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
        // г) Все целые числа от a до b (где b < a)
        for (; ; )
        {
            Console.Write("Введите значение a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b (b < a): ");
            b = int.Parse(Console.ReadLine());
            if (b < a) break;
        }

        Console.WriteLine("Числа от " + a + " до " + b + " в убывающем порядке:");
        for (int i = a; i >= b; i--)
        {
            Console.WriteLine(i);
        }
    }
}
