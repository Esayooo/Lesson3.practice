using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] M = { 1, 2, 3, 4, 5 };
            int[] N = { 3, 4, 5, 6, 7 };

            // Находим общие элементы без повторений
            int[] commonElements = M.Intersect(N).ToArray();

            // Выводим общие элементы в третий массив
            Console.WriteLine("Общие элементы без повторений:");
            foreach (int element in commonElements)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
