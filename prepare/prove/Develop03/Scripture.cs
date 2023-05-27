using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private Reference _scriptureReference;
    
    public Scripture(Reference reference, string word)
    {
        _scriptureReference = reference;
        _words = new List<Word>();

        foreach (string text in word.Split(' '))
        {
            CreateWords(text);
        }
    }
    public void CreateWords(string scriptureText)
    {
        _words.Add(new Word(scriptureText));
    }

    public string GetScripture()
    {
        string output = "";
        foreach (Word word in _words)
        {
            output = output + word.GetWord() + " ";
        }
        return $"{_scriptureReference.GetReference()} {output}";
    }

    public bool HasWordsLeft()
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
                return true;
        }
        return false;
    }

    public void RemoveWords()
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;

        do{
            int rndIndex = new Random().Next(0,_words.Count());
            if (_words[rndIndex].GetIsHidden() == false)
            {
                _words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while (wordsRemoved != numWordsToRemove && this.HasWordsLeft());
    }
}