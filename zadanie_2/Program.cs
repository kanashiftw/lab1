using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int time,h,m,s;
            Console.WriteLine("Введите прошедшее время (в секундах):");
            time = int.Parse(Console.ReadLine());
            h = time / 3600;
            m = ((time - (h * 3600)) / 60);
            s = (time - (h * 3600) - (m * 60));
            Console.Clear();
            Console.WriteLine($"Прошло {h} часов, {m} минут, {s} секунд");
        }
    }
}
