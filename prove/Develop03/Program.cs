using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<string> scripturLibrary = LoadLibrary();
        int selectedIndex = random.Next(0, scripturLibrary.Count());
        string userInput = "";

        do
        {
            Console.Clear();
            Console.Write("""
            Would you like to:

            1) Memorize A Random Scripture
            2) Select A Preexisting Scripture From The Data Base
            3) Add A New Scripture To The Data Base

            Please Type The Number Corresponding With Your Choice: 
            """);
            userInput = Console.ReadLine();
            if (userInput.Contains("2"))
            {
                List<string> refrenceList = new List<string>();
                Console.Clear();
                for (int i = 0; i < scripturLibrary.Count(); i++)
                {
                    string[] parts = scripturLibrary[i].Split("|");
                    refrenceList.Add($"{parts[0]} {parts[1]}:{parts[2]}");
                    Console.WriteLine($"{i + 1}) {refrenceList[i]}");
                }
                Console.WriteLine("\nPlease type the number of the scripture reference you want to memorize: ");
                string selectedReference = Console.ReadLine();
                selectedIndex = int.Parse(selectedReference) - 1;
                userInput = "1";
            }
            else if (userInput.Contains("3"))
            {
                Console.Write("Type The Name Of The Book: ");
                string newScripture = Console.ReadLine() + "|";
                Console.Write("Type The Chapter Number: ");
                newScripture += Console.ReadLine() + "|";
                Console.Write("Type The Verse Number(s): (Ex. 5 or 2-7)");
                newScripture += Console.ReadLine() + "|";
                Console.Write("Type Out The Verse(s): ");
                newScripture += Console.ReadLine();
                NewEntry(newScripture);
            }
            else if (!userInput.Contains("1") && !userInput.Contains("2") && !userInput.Contains("3"))
            {
                Console.WriteLine("That is an invalid response, please type \"1\", \"2\", or \"3\". Hit ENTER to try again.");
                Console.ReadLine();
            }
        } while (!userInput.Contains("1"));

        string[] selectedVerse = scripturLibrary[selectedIndex].Split("|");
        Scripture scripture = new Scripture(selectedVerse[0], selectedVerse[1], selectedVerse[2], selectedVerse[3]);
        Console.Clear();
        Console.Write("How many words would you like to have disapear each time?\nPlease enter an intager: ");
        int dificulty = int.Parse(Console.ReadLine());

        do
        {
            Console.Clear();
            Console.Write($"{scripture.GetRefrence()} -> ");
            foreach (Word word in scripture.GetWords())
            {
                Console.Write($"{word.GetWord()} ");
            }
            Console.WriteLine();
            Console.Write("\nPress ENTER to hide words or type quit to exit:");
            userInput = Console.ReadLine();
            scripture.HideWords(dificulty);
        } while (userInput != "quit" && !scripture.CompletelyHidden());

        Console.Clear();
        Console.Write($"{scripture.GetRefrence()} -> ");
        foreach (Word word in scripture.GetWords())
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
        Console.Write("\nPress ENTER or type quit to exit:");
        Console.ReadLine();
    }

    public static List<string> LoadLibrary()
    {
        List<string> library = new List<string>();
        string[] lines = System.IO.File.ReadAllLines("ScripturLibrary.txt");
        foreach (string line in lines)
        {
            library.Add(line);
        }
        return library;
    }

    public static void NewEntry(string newLine)
    {
        List<string> oldLibrary = LoadLibrary();
        using (StreamWriter streamWriter = new StreamWriter("ScripturLibrary.txt"))
        {
            foreach (string entry in oldLibrary)
            {
                streamWriter.WriteLine(entry);
            }
            streamWriter.WriteLine(newLine);
        }
    }
}