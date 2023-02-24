using System;

class Program
{
    static void Main(string[] args)
    {
        bool loaded = false;
        bool madeChanges = false;
        string fileName = "";
        string userInput;
        Journal newJournal = new Journal();
        do
        {
            Console.Clear();
            Console.WriteLine($"""
            Please select one of the following choices:
            ~ Write
            ~ Display
            ~ Load
            """);
            if (loaded)
            {
                Console.WriteLine("""
                ~ Unload
                ~ Save
                """);
            }
            Console.Write("""
            ~ Save As
            ~ Exit
            What would you like to do? 
            """);
            userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "WRITE":
                    newJournal.Write();
                    madeChanges = true;
                    break;
                case "DISPLAY":
                    newJournal.Display();
                    break;
                case "LOAD":
                    Console.Write("What is the file name? ");
                    fileName = Console.ReadLine();
                    newJournal.Load(fileName);
                    loaded = true;
                    break;
                case "UNLOAD":
                    if (!loaded)
                    {
                        Console.Write("Invalid Input! Hit Enter to Contiune.");
                        Console.ReadLine();
                    }
                    else
                    {
                        loaded = false;
                    }
                    break;
                case "SAVE":
                    if (!loaded)
                    {
                        newJournal.SaveAs();
                    }
                    else
                    {
                        newJournal.Save(fileName);
                    }
                    madeChanges = false;
                    break;
                case "SAVE AS":
                    newJournal.SaveAs();
                    madeChanges = false;
                    break;
                default:
                    if (userInput != "EXIT")
                    {
                        Console.Write("Invalid Input! Hit Enter to Contiune.");
                        Console.ReadLine();
                    }
                    break;
            }
        }
        while (userInput != "EXIT");
        {
            if (madeChanges)
            {
                while (true)
                {
                    Console.Write("You have unsaved changes would you like to save them? (yes/no) ");
                    userInput = Console.ReadLine().ToUpper();
                    Console.WriteLine(userInput);
                    if (userInput == "YES" && loaded)
                    {
                        newJournal.Save(fileName);
                        continue;
                    }
                    else if (userInput == "YES" && !loaded)
                    {
                        newJournal.SaveAs();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Respawns:");
                    }
                }
            }
        }
    }
}