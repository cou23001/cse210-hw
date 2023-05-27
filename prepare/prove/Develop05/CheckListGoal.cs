using System;

public class CheckListGoal: Goal
{
    private int _bonusPoints;
    private int _times;
    private int _timesCompleted;
    public CheckListGoal(string name, string desc, int amount, int bonus, int times): base(name,desc,amount)
    {
        _bonusPoints = bonus;
        _times = times;
        _timesCompleted = 0;
    }
    public void AddTimesToGetBonus()
    {
        _times = _times + 1;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetTimes()
    {
        return _times;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }
    public void AddTimesCompleted()
    {
        if (IsBonus())
            _timesCompleted = 1;
        else
            _timesCompleted = _timesCompleted + 1;
    }
    public int GetCurrentPoints()
    {
        int bonus = 0;
        if (IsBonus()) {
            bonus = GetBonusPoints();
        }
            
        return GetGoalPoints() + bonus;
    }
    public override int RecordEvent()
    {
        AddEvent();
        AddTimesCompleted();
        AddTotalPoints(GetCurrentPoints());
        if (IsBonus()) {
            SetComplete();
        }

        return GetCurrentPoints();
    }
    public bool IsBonus()
    {
        if (_times == _timesCompleted) {
            return true;
        }
        else {
            return false;
        }
    }
    public override bool IsComplete()
    {
        return GetComplete();
    }
    public override string ToDisplay()
    {
        return $"{GetName()} ({GetDescription()}) -- Currently completed: {GetTimesCompleted()}/{GetTimes()}";
    }
    public override string ToCSV()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetGoalPoints()},{GetBonusPoints()},{GetTimes()},{GetTimesCompleted()}";
    }
}