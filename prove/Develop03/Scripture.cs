using System;
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture(string book, string chapter, string verse, string verseText)
    {
        if (verse.Contains("-"))
        {
            string[] multiVerse = verse.Split("-");
            _reference = new Reference(book, int.Parse(chapter), int.Parse(multiVerse[0]), int.Parse(multiVerse[1]));
        }
        else
        {
            _reference = new Reference(book, int.Parse(chapter), int.Parse(verse));
        }
        this.SetWords(verseText);
    }
    public bool CompletelyHidden()
    {
        foreach (Word wordOBJ in _words)
        {
            if (wordOBJ.GetVisibility())
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.Write($"{GetRefrence()} -> ");
        foreach (Word word in GetWords())
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.Write("\n\nPress ENTER to hide words or type quit to exit:");
    }
    public void HideWords(int wordCount = 1)
    {
        Random random = new Random();
        int randIndex = 0;
        int wordsRemoved = 0;
        do
        {
            randIndex = random.Next(0, _words.Count());
            if (_words[randIndex].GetVisibility())
            {
                _words[randIndex].Hide();
                wordsRemoved++;
            }
        }
        while (!CompletelyHidden() && wordsRemoved != wordCount);
    }
    public string GetRefrence()
    {
        return _reference.GetReferenceText();
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public void SetRefrence(Reference reference)
    {
        _reference = reference;
    }
    public void SetWords(string wordsString)
    {
        foreach (string word in wordsString.Split(" "))
        {
            Word newWordOBJ = new Word(word);
            _words.Add(newWordOBJ);
        }
    }
}