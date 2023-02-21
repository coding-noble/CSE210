using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNum != 0)
        {
            Console.Write("Enter Number: ");

            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        numbers.Sort();

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {((float)sum) / numbers.Count}");

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest is: {largest}");

        int smallestPos = 999999999;

        foreach (int number in numbers)
        {
            if (number < smallestPos && number > 0)
            {
                smallestPos = number;
            }
        }
        Console.WriteLine($"The smallest positive is: {smallestPos}");
        Console.WriteLine($"The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}