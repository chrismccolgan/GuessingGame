using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                string answer = Console.ReadLine();
                int num = int.Parse(answer);
                int secretNumber = 42;

                if (num == secretNumber)
                {
                    Console.WriteLine("Congratulations!");
                }
                else if (num != secretNumber)
                {
                    Console.WriteLine("Nope");
                }
            }
        }
    }
}