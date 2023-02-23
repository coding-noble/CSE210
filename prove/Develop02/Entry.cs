using System;

public class Entry
{
    public string _entryDate = DateTime.Now.ToShortDateString();
    public string _userEntry;
    public Prompt _prompt = new Prompt();
}