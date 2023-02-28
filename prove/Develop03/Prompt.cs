using System;

public class Prompt
{
    private static Library _library = new Library();
    private static Scripture _scripture = new Scripture();
    private static Random _rand = new Random();
    private static string _rawRefrence = _library.GetVerse(_rand.Next(0, _library.GetLibraryCount()));
    private string[] _splitScripture = _rawRefrence.Split("|");
    private int _hiddenWordCount = 1;
    public void Display()
    {
        Console.WriteLine(_scripture.GetRefrence());
        Console.WriteLine(_scripture.GetVerse());
    }
    public void SetScripture()
    {
        _scripture.SetRefrence(_splitScripture[0]);
        _scripture.SetVerse(_splitScripture[1]);
    }
    public void HideWords(int repCount = 1)
    {
        string verse = _scripture.GetVerse();
        string[] splitVerse = verse.Split(" ");
        for (int i = 0; i < repCount; i++)
        {
            SetHiddenWordCount(splitVerse.Count());
            foreach (string word in splitVerse)
            {
                if (word.Contains("_"))
                {
                    SetHiddenWordCount(GetHiddenWordCount() - 1);
                }
            }
            int randIndex = _rand.Next(0, splitVerse.Count());
            if (!splitVerse[randIndex].Contains("_") && GetHiddenWordCount() > 0)
            {
                string blanks = "";
                foreach (char letter in splitVerse[randIndex])
                {
                    blanks += "_";
                }
                if (splitVerse[randIndex].EndsWith("."))
                {
                    blanks = blanks.Remove(0, 1) + ".";
                }
                if (splitVerse[randIndex].EndsWith(","))
                {
                    blanks = blanks.Remove(0, 1) + ",";
                }
                if (splitVerse[randIndex].EndsWith(":"))
                {
                    blanks = blanks.Remove(0, 1) + ":";
                }
                if (splitVerse[randIndex].EndsWith(";"))
                {
                    blanks = blanks.Remove(0, 1) + ";";
                }
                splitVerse[randIndex] = blanks;
            }
            else
            {
                i--;
            }
            if (GetHiddenWordCount() == 0)
            {
                break;
            }
        }
        verse = "";
        foreach (string word in splitVerse)
        {
            verse += $" {word}";
        }
        verse = verse.Remove(0, 1);
        _scripture.SetVerse(verse);
        Console.ReadLine();
    }
    public int GetHiddenWordCount()
    {
        return _hiddenWordCount;
    }
    public int SetHiddenWordCount(int num)
    {
        return _hiddenWordCount = num;
    }
}