using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    private static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    private static int SquareNumber(int number)
    {
        return number * number;
    }

    private static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    private static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    private static void DisplayWelcomeMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine();
        Console.WriteLine();
    }
}