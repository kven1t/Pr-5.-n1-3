using System;
using System.Xml.Linq;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; //Объявление переменных
            do //Цикл
            {
                Console.Write("Введите высоту прямоугольник: "); //Вывод текста
                x = double.Parse(Console.ReadLine()); //Присвоение переменной, которая считается с верхней строки
                if (x <= 0) //Цикл
                    Console.WriteLine("Введите положительно число"); //Вывод текста
            } while (x <= 0);

            do //Цикл
            {
                Console.Write("Введите длину прямоугольник: "); //Вывод текста
                y = double.Parse(Console.ReadLine()); //Присвоение переменной, которая считается с верхней строки
                if (y <= 0) //Цикл
                    Console.WriteLine("Введите положительно число"); //Вывод текста
            } while (y <= 0);

            Console.WriteLine($"Периметр: {{0:F1}}", 2 * (x + y)); //Вывод указанных данных
            Console.WriteLine($"Диагональ: {{0:F1}}", Math.Sqrt(x * x + y * y)); //Вывод указанных данных
        }
    }
}
