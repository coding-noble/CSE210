using System;

public class Scripture
{
    private string _reference;
    private string _scripture;

    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;
    }
    public Scripture()
    {
        _reference = null;
        _scripture = null;
    }
    public string GetVerse()
    {
        return _scripture;
    }
    public string SetVerse(string verse)
    {
        return _scripture = verse;
    }
    public string GetRefrence()
    {
        return _reference;
    }
    public string SetRefrence(string reference)
    {
        return _reference = reference;
    }
}