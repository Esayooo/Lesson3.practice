using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание одномерного массива A
            double[] A = new double[5];

            // Заполнение массива A числами, введенными с клавиатуры
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива A: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            // Создание двумерного массива B (3 строки, 4 столбца)
            double[,] B = new double[3, 4];

            // Заполнение массива B случайными числами
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble();
                }
            }

            // Вывод значений массива A в одну строку
            Console.Write("Массив A: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            // Вывод значений массива B в виде матрицы
            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Нахождение максимального и минимального элементов в массивах
            double maxA = A[0];
            double minA = A[0];
            double maxB = B[0, 0];
            double minB = B[0, 0];

            foreach (double num in A)
            {
                if (num > maxA)
                    maxA = num;
                if (num < minA)
                    minA = num;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > maxB)
                        maxB = B[i, j];
                    if (B[i, j] < minB)
                        minB = B[i, j];
                }
            }

            // Вычисление общей суммы и произведения всех элементов
            double sumA = 0;
            double productA = 1;
            double sumB = 0;
            double productB = 1;

            foreach (double num in A)
            {
                sumA += num;
                productA *= num;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumB += B[i, j];
                    productB *= B[i, j];
                }
            }

            // Сумма четных элементов массива A
            double sumEvenA = 0;
            foreach (double num in A)
            {
                if (num % 2 == 0)
                    sumEvenA += num;
            }

            // Сумма нечетных столбцов массива B
            double sumOddColumnsB = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }
            }

            // Вывод результатов
            Console.WriteLine($"Максимальный элемент в A: {maxA}");
            Console.WriteLine($"Минимальный элемент в A: {minA}");
            Console.WriteLine($"Общая сумма элементов в A: {sumA}");
            Console.WriteLine($"Общее произведение элементов в A: {productA}");
            Console.WriteLine($"Максимальный элемент в B: {maxB}");
            Console.WriteLine($"Минимальный элемент в B: {minB}");
            Console.WriteLine($"Общая сумма элементов в B: {sumB}");
            Console.WriteLine($"Общее произведение элементов в B: {productB}");
            Console.WriteLine($"Сумма четных элементов в A: {sumEvenA}");
            Console.WriteLine($"Сумма нечетных столбцов в B: {sumOddColumnsB}");
        }
    }
}
