using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac22
{
    class Program
    {
        static void Main(string[] args)
        {
            pain User = new pain();
            Console.WriteLine("Ваши текущие параметры:");
            Console.WriteLine();
            Console.WriteLine($"Имя - {User.name}");
            Console.WriteLine($"Фамилия - {User.firstname}");
            Console.WriteLine($"Возраст - {User.years}");
            Console.WriteLine($"Рост (См) - {User.height}");
            Console.WriteLine($"Вес (Кг) - {User.weight}");
           

            Console.WriteLine();//Имя
            pain.SetName();
            Console.WriteLine();//Фамилия
            pain.Setfirstname();
            Console.WriteLine();//Лет
            pain.Setyears();
            Console.WriteLine();//Рост
            pain.Setheight();
            Console.WriteLine();//Вес
            pain.Setweight();
            


        }
    }
}
