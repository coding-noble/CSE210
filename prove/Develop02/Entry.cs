using System;

public class Entry
{
    public string _entryDate = DateTime.Now.ToShortDateString();
    public Prompt _prompt = new Prompt();
    public string _userEntry;
    public void Display()
    {
        Console.WriteLine($"{_entryDate}: {_prompt._promptText}: {_userEntry}");
    }
}