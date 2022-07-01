using System;

namespace _3._10_2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Добро пожаловать в игру Blackjack!");
            Console.Write($"\nВведите кол-во карт у вас на руках: ");
            int countCard = Convert.ToInt32(Console.ReadLine());
            int sumValue = 0;
            int value = 0;

            for (int i = 1; i <= countCard; i++)
            {
                Console.Write($"\nВведите номинал {i}-й карты: ");
                string cardValue = Console.ReadLine();

                switch (cardValue)
                {
                    case "2":
                        value = 2;
                        break;
                    case "3":
                        value = 3;
                        break;
                    case "4":
                        value = 4;
                        break;
                    case "5":
                        value = 5;
                        break;
                    case "6":
                        value = 6;
                        break;
                    case "7":
                        value = 7;
                        break;
                    case "8":
                        value = 8;
                        break;
                    case "9":
                        value = 9;
                        break;
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        value = 10;
                        break;
                    default:
                        Console.WriteLine($"\nДопустимы номиналы карт от 2 до 10.\nДля картинок J, Q, K, T.");
                        break;
                }

                sumValue += value;

            }

            Console.WriteLine($"\nСумма ваших карт = {sumValue}");
            Console.ReadKey();
        }
    }
}
