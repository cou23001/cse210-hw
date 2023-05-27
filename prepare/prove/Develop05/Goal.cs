using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _amountPoints;
    private int _totalPoints;
    private int _numberEvents;
    private bool _complete;

    public Goal (string name, string desc, int amount)
    {
        _name = name;
        _description = desc;
        _amountPoints = amount;
        _complete = false;
        _totalPoints = 0;
        _numberEvents = 0;
    }

    public void AddEvent()
    {
        _numberEvents = _numberEvents + 1;
    }
    //public abstract void AddPoints();

    public void AddTotalPoints(int points = 0)
    {
        _totalPoints = _totalPoints + points;
    }
    public int GetGoalPoints()
    {
        return _amountPoints;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetComplete()
    {
        _complete = true;
    }

    public bool GetComplete()
    {
        return _complete;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string ToDisplay();
    public abstract string ToCSV();
}