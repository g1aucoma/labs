using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1. Разработкаконсольного предложения"); //Вариант 1
            Console.WriteLine("Прохоров Никита Юрьевич");
            Console.WriteLine("ИНС-192");
            Console.WriteLine("14.07.2001");
            Console.WriteLine("г.Михайловск");
            Console.WriteLine("Математика");
            Console.WriteLine("Холодное оружие");

            int a_1, b, a, x, y5, F;
            a_1 = 14;
            b = 9;
            a = 21;
            x = 6;
            y5 = 11;
            

            Console.WriteLine("Значение переменной a_1 равно {0}", a_1);
            Console.WriteLine("Значение переменной b равно {0}", b);
            Console.WriteLine("Значение переменной a равно {0}", a);
            Console.WriteLine("Значение переменной x равно {0}", x);
            Console.WriteLine("Значение переменной y5 равно {0}", y5);
            Console.WriteLine("Значение переменной F={0}+{1}-{2}*({3}+{4})={5}", a_1, b, a, x, y5, a_1+b-a*(x+y5));

            Console.ReadKey();
        }
    }
}
