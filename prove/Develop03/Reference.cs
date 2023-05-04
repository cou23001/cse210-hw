using System;

public class Reference
{
    string _book;
    string _chapter;
    string _verseStart;
    string _verseEnd;

    public Reference(string book, string chapter, string singleVerse) {
        _book = book;
        _chapter = chapter;
        _verseStart = singleVerse;
        _verseEnd = "";
    }

    public Reference(string book, string chapter, string verseStart, string verseEnd) {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReference()
    {
        if (_verseEnd.Length == 0)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}