using System;

namespace zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, ans;
            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
            ans = (((3 * x - 5)*x+2)*x-1)*x+7;
            Console.WriteLine($"Ответ: {ans}");
        }
    }
}
