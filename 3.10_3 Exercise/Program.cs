﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_3_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            bool primeNumber = true;

            int i = 2;
            while (i <= number - 1)
            {
                if (number % i == 0)
                {
                    primeNumber = false;
                    break;
                }
                i++;
            }
            if (primeNumber)
            {
                    Console.WriteLine($"\nЧисло {number} простое");
            }
            else
            {
                    Console.WriteLine($"\nЧисло {number} не простое");
            }
               
            Console.ReadKey();
        }
    }
}
