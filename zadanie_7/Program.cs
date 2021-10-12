using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;          
                Console.WriteLine("Введите трёхзначное число");
            a = int.Parse(Console.ReadLine());
            if (a>999 ^ a<100)
            {do
             {
                Console.WriteLine("Число не трёхзначное, попробуйте еще раз");
                a = int.Parse(Console.ReadLine());
             }while (a>999 ^ a<100);
            }
            else
            {
                string b = a.ToString();
                char[] bReverse = b.ToCharArray();
                Array.Reverse(bReverse);
                b = new string(bReverse);
                Console.WriteLine(b);
            }
        }
    }
}
