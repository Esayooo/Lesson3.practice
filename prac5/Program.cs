using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            // Заполняем массив случайными числами от -100 до 100
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            // Находим минимальный и максимальный элементы
            int min = array[0, 0];
            int max = array[0, 0];
            int minRow = 0, minCol = 0;
            int maxRow = 0, maxCol = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            // Находим сумму элементов между минимальным и максимальным элементами
            int sum = 0;

            for (int i = Math.Min(minRow, maxRow) + 1; i < Math.Max(minRow, maxRow); i++)
            {
                for (int j = Math.Min(minCol, maxCol) + 1; j < Math.Max(minCol, maxCol); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Сумма элементов между минимальным и максимальным: {sum}");
        }
    }
}
