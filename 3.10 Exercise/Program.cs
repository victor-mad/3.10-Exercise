using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_1_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"Данное число {number} - четное!");
            }
            else
            {
                Console.WriteLine($"Данное число {number} - нечетное!");
            }

            Console.ReadKey();
        }
    }
}
