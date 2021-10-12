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
            Console.WriteLine("Введите кол-во минут(60>m>=0):");
            m = int.Parse(Console.ReadLine());
            if (m<0 || m > 59)
            {
                do
                {
                    Console.WriteLine("Введите корректное время");
                    m = int.Parse(Console.ReadLine());
                }while(m < 0 || m > 59);
            }
            Console.WriteLine("Введите кол-во секунд(60>s>=0):");
            s = int.Parse(Console.ReadLine());
            if (s < 0 || s > 59)
            {
                do
                {
                    Console.WriteLine("Введите корректное время");
                    s = int.Parse(Console.ReadLine());
                } while (s < 0 || s> 59);
            }
            d = ((3600 * h) + (60 * m) + s) * 0.00833333333;
            Console.WriteLine($"Часовая стрелка отклонилась на {d} градусов");
        }
    }
}
