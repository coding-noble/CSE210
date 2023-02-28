using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Prompt prompt = new Prompt();
        prompt.SetScripture();
        while (userInput != "quit" && prompt.GetHiddenWordCount() != 0)
        {
            Console.Clear();
            prompt.Display();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to contiune or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            prompt.HideWords(3);
        }
        Console.Clear();
        prompt.Display();
        Console.WriteLine();
        Console.WriteLine("That's all the words Good Luck with memorizing:");
        Console.ReadLine();
    }
}