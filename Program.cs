using System;

namespace модуль_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод размера массива
            Console.Write("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            // Создание массива
            double[] array = new double[N];
            // Ввод элементов массива
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            // Поиск максимального по модулю элемента
            double maxAbs = Math.Abs(array[0]);
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(array[i]) > maxAbs)
                {
                    maxAbs = Math.Abs(array[i]);
                }
            }
            // Нормировка элементов массива
            for (int i = 0; i < N; i++)
            {
                array[i] /= maxAbs;
            }
            // Вывод нормированных значений
            Console.WriteLine("Нормированные элементы массива:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Элемент {i + 1}: {array[i]:F4}");
            }
        }
    }
}