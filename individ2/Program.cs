using System;

namespace indiv2
{
    class Program
    {
        static void Main(string[] args)
        {      
            double e = 2.71828;
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
          Console.WriteLine($"Введите x (x > {-a})");
            double x = double.Parse(Console.ReadLine());
            if (x < -a)
            {
                do
                {
                    Console.WriteLine($"Введите число большее чем{-a}");
                    x = double.Parse(Console.ReadLine());
                } while (x < -a);
            }
            Console.WriteLine("Введите b отличное от нуля");
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    b = double.Parse(Console.ReadLine());
                } while (b == 0);
            }
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            double first = Math.Log(a+Math.Pow(x,2));
            double second = 0.5*(1-Math.Cos(2*(x / b)));
            Console.Clear();
            Console.WriteLine($"Ответ по первой формуле:{first + second}");
            //(x - Math.Sqrt(Math.Abs(x-b)))<>0
            double ans = Math.Pow(e, -c*x)*((x+Math.Sqrt(x+a))/(x - Math.Sqrt(Math.Abs(x - b))));
            Console.WriteLine($"Ответ по второй формуле:{ans}");
        }
    }
}
