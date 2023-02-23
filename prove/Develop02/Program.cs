using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        Journal newJournal = new Journal();
        do
        {
            Console.Clear();
            Console.Write("""
            Please select one of the following choices:
            1: Write
            2: Display
            3: Load
            4: Save
            5: Exit
            What would you like to do? 
            """);
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    newJournal.Write();
                    break;
                case 2:
                    newJournal.Display();
                    break;
                case 3:
                    newJournal.Load();
                    break;
                case 4:
                    newJournal.Save();
                    break;
                default:
                    Console.Write("Invalid Input! Hit Enter to Contiune.");
                    Console.Read();
                    break;
            }
        }
        while (userInput != 5);
    }
}