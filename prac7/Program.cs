﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку длиной 20 символов: ");
            string input = Console.ReadLine();

            if (input.Length != 20)
            {
                Console.WriteLine("Введенная строка не имеет длину 20 символов.");
            }
            else
            {
                int digitCount = 0;  // Инициализируем счетчик цифр

                for (int i = 0; i < 20; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        digitCount++;
                    }
                }

                Console.WriteLine($"Количество цифр в строке: {digitCount}");
            }
        }
    }
}
