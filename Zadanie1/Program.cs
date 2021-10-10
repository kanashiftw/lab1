using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Введите число");
            a = float.Parse(Console.ReadLine());
            int b = (int)a;
            float c = (a - b)*10;
            c = (int)c;
            Console.WriteLine(c);
        }
    }
}
