using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            // Разбиваем введенную строку на слова с помощью пробелов
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Количество слов - это длина массива words
            int wordCount = words.Length;

            Console.WriteLine($"Количество слов в предложении: {wordCount}");
        }
    }
}
