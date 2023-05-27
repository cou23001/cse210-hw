using System;

public class Word{

    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public string GetWord()
    {
        if (GetIsHidden() == false)
            return _word;
        else {
            string output = "";
            foreach (char c in _word)
            {
                output = output + "_";
            }
            return output;
        }
    }
}