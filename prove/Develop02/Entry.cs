using System;
public class Entry {

    public string _prompt {get; set;}
    public string _message {get; set;}
    public string _location {get; set;}
    public DateTime _dateTime {get; set;}

    public Entry(string prompt, string message, string location, DateTime date)
    {
        _prompt = prompt;
        _message = message;
        _location = location;
        _dateTime = date;
    }

    public override string ToString()
    {
        return $"{_dateTime.ToString("MM/dd/yyyy")}|{_prompt}|{_message}|{_location}";
    }

    public string ToDisplay()
    {
        return $"Date: {_dateTime.ToString("MM/dd/yyyy")} - Location: {_location} - Prompt: {_prompt}\n{_message} ";
    }
}