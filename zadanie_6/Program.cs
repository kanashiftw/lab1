using System;

namespace Proizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,x,y,z,k,ans;
            Console.WriteLine("Введите четырехзначное число:");
            num = int.Parse(Console.ReadLine());
            if (num < 1000 ^ num > 9999)
            {
                do
                {
                    Console.WriteLine("Число не четырехзначное, попробуйте еще раз");
                    num = int.Parse(Console.ReadLine());
                } while (num < 1000 ^ num > 9999);
            }          
            {
                x = num / 1000;
                y = (num - (x * 1000)) / 100;
                z = (num - (x * 1000) - (y * 100))/10;
                k = (num - (x * 1000)) - (y * 100) - (z * 10);
                ans = x * y * z * k;
                Console.WriteLine($"Произведение цифр данного четырехзначного числа:{ans}");
            }
        }
    }
}
