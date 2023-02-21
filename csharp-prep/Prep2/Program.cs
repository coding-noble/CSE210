using System;

class Program
{
    static void Main(string[] args)
    {
        bool passed = false;
        char letter = 'F';
        char modifier = ' ';
        Console.Write("What is your grade percentage? ");
        string userGradePer = Console.ReadLine();

        if (int.Parse(userGradePer) >= 90)
        {
            letter = 'A';
            passed = true;
        }
        else if (int.Parse(userGradePer) >= 80)
        {
            letter = 'B';
            passed = true;
        }
        else if (int.Parse(userGradePer) >= 70)
        {
            letter = 'C';
            passed = true;
        }
        else if (int.Parse(userGradePer) >= 60)
        {
            letter = 'D';
        }

        if (letter != 'F' && (int.Parse(userGradePer) % 10) >= 7)
        {
            modifier = '+';
        }
        else if (letter != 'F' && (int.Parse(userGradePer) % 10) <= 3)
        {
            modifier = '-';
        }
        if (letter == 'A' && modifier == '+')
        {
            modifier = ' ';
        }

        Console.WriteLine($"You got a {letter}{modifier}");

        if (passed)
        {
            Console.WriteLine("You Passed!!!");
        }
        else
        {
            Console.WriteLine("Better luck next time :(");
        }
    }
}