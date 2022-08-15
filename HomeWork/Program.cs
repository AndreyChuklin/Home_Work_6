using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha43()
            {
                // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
                // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

                Console.WriteLine("Ведите первую точку координат ");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите вторую точку координат ");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите третью точку координат ");
                int k2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите четвертую точку координат ");
                int b2 = Convert.ToInt32(Console.ReadLine());

                if (k1 == k2)
                {
                    Console.WriteLine("без точки пересечения, прямые параллельны");
                }
                else
                {
                    double x = (b2 - b1) / (k1 - k2);
                    double y = k1 * x + b1;
                    double y2 = k2 * x + b2;
                    Console.WriteLine($"координаты точки пересечения А({Math.Round(x, 2)}, {Math.Round(y)})");
                    Console.WriteLine($"координаты точки пересечения A({Math.Round(x, 2)}, {Math.Round(y2)})");
                }
            }


            void Zadacha41()
            {
                // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

                Console.WriteLine("Введите числа, сколько Вы хотите ");
                int number = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                for (int i = 0; i < number; i++)
                {
                    Console.Write("Введите любое число: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (m > 0) count++;
                }
                Console.WriteLine($"Было введено {count} числа больше 0");
            }


            Zadacha43();
            //Zadacha41();
        }

    }
}
