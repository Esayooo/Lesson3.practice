using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "ваша последовательность букв"; // Замените на свою последовательность букв

            string yourName = "ваше имя"; // Замените на своё имя

            bool canSpellName = CanSpellName(input, yourName);

            if (canSpellName)
            {
                Console.WriteLine("Можно составить ваше имя: " + yourName);
            }
            else
            {
                Console.WriteLine("Нет имени.");
            }
        }

        static bool CanSpellName(string input, string name)
        {
            int[] nameCharCount = new int[26]; // Массив для подсчета количества букв в имени

            // Заполняем массив nameCharCount количеством букв в имени
            foreach (char c in name)
            {
                if (char.IsLetter(c))
                {
                    nameCharCount[char.ToLower(c) - 'a']++;
                }
            }

            // Проверяем, есть ли достаточное количество каждой буквы в последовательности символов
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int index = char.ToLower(c) - 'a';
                    if (nameCharCount[index] > 0)
                    {
                        nameCharCount[index]--;
                    }
                }
            }

            // Проверяем, остались ли недостающие буквы в имени
            return Array.TrueForAll(nameCharCount, count => count <= 0);
        }
    }
}
