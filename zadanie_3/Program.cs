using System;

namespace Gradusi
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            double d;
            Console.WriteLine("Введите кол-во часов:");
            h = int.Parse(Console.ReadLine());
            if (h>11){
                h = h - (12*(h/12));
            }
            Console.WriteLine("Введите кол-во минут:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во секунд:");
            s = int.Parse(Console.ReadLine());
            d = ((3600 * h) + (60 * m) + s) * 0.00833333333;
            Console.WriteLine($"Часовая стрелка отклонилась на {d} градусов");
        }
    }
}
