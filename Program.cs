using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                string answer = Console.ReadLine();
                int num = int.Parse(answer);

                if (num == secretNumber)
                {
                    Console.WriteLine("Congratulations!");
                    break;
                }
                else if (num != secretNumber)
                {
                    Console.WriteLine($"Nope! Chances remaining: {3-i}");
                }
            }
        }
    }
}