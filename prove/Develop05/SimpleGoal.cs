using System;

public class SimpleGoal: Goal
{

    public SimpleGoal(string name, string desc, int amount): base(name, desc, amount)
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
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetGoalPoints()},{IsComplete()}";
    }
}