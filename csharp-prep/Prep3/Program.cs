using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";
        int userGuess = -1;
        int magicNumber;
        int guessCount;

        while (playAgain.ToLower() == "yes")
        {
            guessCount = 0;
            magicNumber = randomGenerator.Next(1, 101);
            // Console.WriteLine(magicNumber);
            while (userGuess != magicNumber)
            {
                Console.Write("What is your userGuess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You userGuessed it!");
                }

                guessCount += 1;
            }
            Console.WriteLine($"It took you {guessCount} try(s).");
            Console.Write($"Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}