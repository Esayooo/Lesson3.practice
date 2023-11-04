using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку с малыми русскими буквами: ");
            string input = Console.ReadLine();

            string uppercaseInput = ConvertToUppercase(input);

            Console.WriteLine("Преобразованная строка: " + uppercaseInput);
        }
        static string ConvertToUppercase(string input)
        {
            // Создаем пустую строку, в которую будем добавлять большие буквы
            string result = "";

            // Проходим по каждому символу в исходной строке
            foreach (char character in input)
            {
                // Проверяем, является ли символ малой русской буквой
                if (IsLowerCyrillic(character))
                {
                    // Преобразуем малую букву в большую и добавляем к результату
                    char uppercaseChar = char.ToUpper(character);
                    result += uppercaseChar;
                }
                else
                {
                    // Если символ не является малой русской буквой, добавляем его без изменений
                    result += character;
                }
            }

            return result;
        }

        // Функция для проверки, является ли символ малой русской буквой
        static bool IsLowerCyrillic(char character)
        {
            return character >= 'а' && character <= 'я';
        }
    }
}
