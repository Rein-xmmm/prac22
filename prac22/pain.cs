using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac22
{
    class pain

    {
        public string name = "Алишер";
        public string firstname = "Бозорбаев";
        public int weight = 50;
        public int height = 164;
        public int years = 17;

        static internal string SetName()
        {
            Console.WriteLine("Введите ваше имя");
            string d = Console.ReadLine();
            Console.WriteLine($"Ваше новое имя - {d} (старой было лучше)");
            return d;
        }
        static internal string Setfirstname()
        {
            Console.WriteLine("Введите вашу фамилию");
            string o = Console.ReadLine();
            Console.WriteLine($"Ваша новая фамилия - {o}");
            return o;
        }

        static internal int Setweight()
        {
            Console.WriteLine("Введите ваш вес (Кг)");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш новый вес (Кг) - {A}");
            return A;
        }
        static internal int Setheight()
        {
            Console.WriteLine("Введите ваш рост (См)");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш новый рост (См) - {a}");
            return a;
        }

        static internal int Setyears()
        {
            Console.WriteLine("Введите ваш возраст");
            int godik = Convert.ToInt32(Console.ReadLine());
            {
                if (godik >= 20)

                {
                    Console.WriteLine($"вам уже {godik} пара уже на пенсию? :D ");
                    Console.ReadLine();
                }

            }
            return godik;
        }
    }
}