using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void Write()
    {
        Entry entry = new Entry();
        Console.WriteLine($"{entry._prompt._promptText}");
        Console.Write(">");
        entry._userEntry = Console.ReadLine();
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._entryDate}: {entry._prompt._promptText}: {entry._userEntry}");
        }
        Console.ReadLine();
    }

    public void Load()
    {
        _entries.Clear();
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(": ");
            string oldDate = parts[0];
            string oldPrompt = parts[1];
            string oldEntry = parts[2];
            Entry entry = new Entry();
            entry._entryDate = oldDate;
            entry._prompt._promptText = oldPrompt;
            entry._userEntry = oldEntry;
            _entries.Add(entry);
        }
    }
    public void Save()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }
        using (StreamWriter streamWriter = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                streamWriter.WriteLine($"{entry._entryDate}: {entry._prompt._promptText}: {entry._userEntry}");
            }
        }
    }
}