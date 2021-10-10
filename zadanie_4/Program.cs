using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int First, Second;
            Console.WriteLine("Введите первое число");
            First = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            Second = int.Parse(Console.ReadLine());
            First = First + Second;
            Second = First - Second;
            First = First - Second;
            Console.WriteLine($"Первое число:{First}, Второе число:{Second}");
        }
    }
}
