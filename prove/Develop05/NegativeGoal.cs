using System;

public class NegativeGoal: Goal
{
    public NegativeGoal(string name, string desc, int amount): base(name, desc, amount)
    {
    
    }
    public override int RecordEvent()
    {
        AddEvent();
        AddTotalPoints(GetGoalPoints());
        SetComplete();

        return GetGoalPoints();
    }
    public override bool IsComplete()
    {
        return GetComplete();
    }
    public override string ToDisplay()
    {
        return $"{GetName()} ({GetDescription()})";
    }
    public override string ToCSV()
    {
        return $"NegativeGoal:{GetName()},{GetDescription()},{GetGoalPoints()},{IsComplete()}";
    }
}