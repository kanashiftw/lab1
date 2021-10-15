using System;

namespace zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, ax, ay, az, ad, x, y, z;
            Console.WriteLine("Три уравнения вида ax + by + cz = d");
            Console.WriteLine("Введите a1 отличное от нуля");
            a1 = float.Parse(Console.ReadLine());
            if (a1 == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    a1 = float.Parse(Console.ReadLine());
                } while (a1 == 0);
            }
            Console.WriteLine("Введите b1");
            b1 = float.Parse(Console.ReadLine());
            if (b1 == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    b1 = float.Parse(Console.ReadLine());
                } while (b1 == 0);
            }
            Console.WriteLine("Введите c1");
            c1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите ответ первого уравнения отличный от нуля");
            d1 = float.Parse(Console.ReadLine());
            if (d1 == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    d1 = float.Parse(Console.ReadLine());
                } while (d1 == 0);
            }
            Console.WriteLine("Введите a2");
            a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b2");
            b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c2");
            c2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите ответ второго уравнения отличный от нуля");
            d2 = float.Parse(Console.ReadLine());
            if (d2 == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    d2 = float.Parse(Console.ReadLine());
                } while (d2 == 0);
            }
            Console.WriteLine("Введите a3");
            a3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b3");
            b3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c3");
            c3 = float.Parse(Console.ReadLine());
            if (c3 == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    c3 = float.Parse(Console.ReadLine());
                } while (c3 == 0);
            }
            Console.WriteLine("Введите ответ третьего уравнения отличный от нуля");
            d3 = float.Parse(Console.ReadLine());
            if (d3 == 0)
            {
                do
                {
                    Console.WriteLine("Введите число отличное от нуля");
                    d3 = float.Parse(Console.ReadLine());
                } while (d3 == 0);
            }
            Console.WriteLine($"{a1}x+{b1}y+{c1}z={d1}");
            Console.WriteLine($"{a2}x+{b2}y+{c2}z={d2}");
            Console.WriteLine($"{a3}x+{b3}y+{c3}z={d3}");

            ax = a1 * a2 / a1;
            ay = b1 * a2 / a1;
            az = c1 * a2 / a1;
            ad = d1 * a2 / a1;
            a2 = a2 - ax;
            b2 = b2 - ay;
            c2 = c2 - az;
            d2 = d2 - ad;
            ax = a1 * a3 / a1;
            ay = b1 * a3 / a1;
            az = c1 * a3 / a1;
            ad = d1 * a3 / a1;
            a3 = a3 - ax;
            b3 = b3 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            ay = b2 * b3 / b2;
            az = c2 * b3 / b2;
            ad = d2 * b3 / b2;
            b3 = b3 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            z = d3 / c3;
            y = (d2 - c2 * z) / b2;
            x = (d1 - c1 * z - b1 * y) / a1;
            Console.WriteLine("Ответ:");
            Console.WriteLine($"x={x};y={y};z={z}");
        }
    }
}
