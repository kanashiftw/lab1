using System;
using System.Collections;

namespace individ1
{
    public class OOP
    {
        public enum Type
        {
            F, US
        }
        public class Country
        {
            public String StateName;
            public String Capital;
            public int population;
            public Type CountryType;
            public Country(string StateName, string Capital, int population, Type CountryType)
            {
                this.StateName = StateName;
                this.Capital = Capital;
                this.population = population;
                this.CountryType = CountryType;
            }
            public void Print()
            {
                Console.WriteLine($"|{this.StateName,-25}|{this.Capital,-13}|{this.population,-21}|{this.CountryType,-16}|");
            }
        }
        private static void Main()
        {
            ArrayList list = new();      
            bool point = true;
            while (point)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Название гос-ва:");
                string name = Console.ReadLine();
                Console.WriteLine("Столица:");
                string Capital = Console.ReadLine();
                Console.WriteLine("Кол-во населения:");
                int population = int.Parse(Console.ReadLine());
                Type CountryType;
                while (true)
                {
                    Console.WriteLine("Перечисляемый тип(F, US):");
                    string fg = Console.ReadLine();
                    if (fg == "F")
                    {
                        CountryType = Type.F;
                        break;
                    }
                    else if (fg == "US")
                    {
                        CountryType = Type.US;
                        break;
                    }
                    else Console.WriteLine("Некорректный ввод значения. Введите еще раз.");
                }             
                Country value = new(name, Capital, population, CountryType);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            point = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }
            }
            Console.WriteLine(new String('-', 80));
            Console.WriteLine($"{"|География",-79}|");
            Console.WriteLine(new String('-', 80));
            Console.WriteLine($"{"|Государство",-26}|{"Столица",-13}|{"Население",-21}|{"Тип",-16}|");
            Console.WriteLine(new String('-', 79));
            foreach (Country item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 80));
            }
            Console.WriteLine($"{"|Перечисляемый тип: F – федерация, US - унитарное гос-во",-79}|");
            Console.WriteLine(new String('-', 80));
        }
    }
}