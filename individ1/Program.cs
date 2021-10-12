using System;

namespace individ1
{
    class Program
    {
        static void Main(string[] args)
        {
            String state1,state2,state3, capital1,capital2,capital3, gvm1,gvm2,gvm3;
            int population1,population2,population3;
            {
                Console.WriteLine("Первое гос-во:");
                Console.WriteLine("Введите гос-во:");
                state1 = Console.ReadLine();
                Console.WriteLine("Введите столицу этого гос-ва:");
                capital1 = Console.ReadLine();
                Console.WriteLine("Введите кол-во населения этого гос-ва:");
                population1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип гос. строя(F или US):");
                gvm1 = Console.ReadLine();
                Console.WriteLine("Второе гос-во:");
                Console.WriteLine("Введите гос-во:");
                state2 = Console.ReadLine();
                Console.WriteLine("Введите столицу этого гос-ва:");
                capital2 = Console.ReadLine();
                Console.WriteLine("Введите кол-во населения этого гос-ва:");
                population2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип гос. строя(F или US):");
                gvm2 = Console.ReadLine();
                Console.WriteLine("Третье гос-во");
                Console.WriteLine("Введите гос-во:");
                state3 = Console.ReadLine();
                Console.WriteLine("Введите столицу этого гос-ва:");
                capital3 = Console.ReadLine();
                Console.WriteLine("Введите кол-во населения этого гос-ва:");
                population3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите тип гос. строя(F или US):");
                gvm3 = Console.ReadLine();
                Console.Clear();
            }
            {
                Console.WriteLine("География");
                Console.WriteLine("Страна\t\t\tСтолица\t\t\tНаселение\t\tГос-строй");
                Console.WriteLine($"{state1}\t\t\t{capital1}\t\t\t{population1}\t\t\t{gvm1}");
                Console.WriteLine($"{state2}\t\t\t{capital2}\t\t\t{population2}\t\t\t{gvm2}");
                Console.WriteLine($"{state3}\t\t\t{capital3}\t\t\t{population3}\t\t\t{gvm3}");
                Console.WriteLine("Перечисляемый тип: Ф - федерация, УГ - унитарное государство");
            }
        }
    }
}
