using System;

public class Library
{
    private List<string> _library = new List<string>
    {
        "Acts 7:45|Which also our fathers that came after brought in with Jesus into the possession of the Gentiles, whom God drave out before the face of our fathers, unto the days of David;",
        "Hebrews 4:8|For if Jesus had given them rest, then would he not afterward have spoken of another day.",
        "Matthew 1:25|And knew her not till she had brought forth her firstborn son: and he called his name JESUS.",
        "Luke 1:31|And, behold, thou shalt conceive in thy womb, and bring forth a son, and shalt call his name JESUS."
    };

    public string GetVerse(int index)
    {
        return _library[index];
    }

    public int GetLibraryCount()
    {
        return _library.Count();
    }
}