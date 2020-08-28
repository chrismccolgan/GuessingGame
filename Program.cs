using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            Console.Write("Please choose a difficulty level (Easy/Medium/Hard): ");
            string level = Console.ReadLine().ToLower();
            int chances = 0;

            while (level != "easy" && level != "medium" && level != "hard" && level != "cheater")
            {
                Console.Write("Please choose a difficulty level, don't be a \"Cheater\" (Easy/Medium/Hard): ");
                level = Console.ReadLine().ToLower();
            }

            if (level == "easy")
            {
                chances = 8;
            }
            else if (level == "medium")
            {
                chances = 6;
            }
            else if (level == "hard")
            {
                chances = 4;
            }
            else if (level == "cheater")
            {
                chances = 10000;
            }

            int[] numbersGuessed = new int[chances];

            for (int i = 0; i < chances; i++)
            {
                Console.WriteLine("Number Guessed " + "=" + "[{0}]", string.Join(", ", numbersGuessed));

                Console.Write("Guess the secret number: ");
                string answer = Console.ReadLine();
                int num = int.Parse(answer);
                numbersGuessed[i] =  num;
                

                if (num == secretNumber)
                {
                    Console.WriteLine("Congratulations!");
                    break;
                }
                else
                {
                    if (num > secretNumber)
                    {
                        Console.WriteLine($"Too high! Chances remaining: {chances-i-1}");
                    }
                    else
                    {
                        Console.WriteLine($"Too low! Chances remaining: {chances-i-1}");
                    }
                }
            }
        }
    }
}