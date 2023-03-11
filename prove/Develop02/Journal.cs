using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void Write()
    {
        Entry newEntry = new Entry();
        Console.WriteLine($"{newEntry._prompt._promptText}");
        Console.Write(">");
        newEntry._userEntry = Console.ReadLine();
        _entries.Add(newEntry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.ReadLine();
    }
    public void Load()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        _entries.Clear();
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
    public void Save(string fileName)
    {
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
    public void SaveAs()
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