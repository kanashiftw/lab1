using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            double First, Second, Hypo,P,S;
            Console.WriteLine("Введите длину первого катета");
            First = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета");
            Second = double.Parse(Console.ReadLine());

            Hypo = Math.Sqrt((First * First) + (Second * Second));
            P = First + Second + Hypo;
            S = 0.5 * (First * Second);
            Console.WriteLine($"Периметр:{P}, Площадь:{S}");
        }
    }
}
