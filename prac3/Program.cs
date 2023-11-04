using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // Удаляем пробелы и приводим к нижнему регистру для упрощения сравнения
            string cleanInput = input.Replace(" ", "").ToLower();

            bool isPalindrome = true;

            for (int i = 0, j = cleanInput.Length - 1; i < j; i++, j--)
            {
                if (cleanInput[i] != cleanInput[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Это палиндром.");
            }
            else
            {
                Console.WriteLine("Это не палиндром.");
            }
        }
    }
}
