using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string desc, int amount): base(name,desc,amount)
    {

    }
    public override int RecordEvent()
    {
        AddEvent();
        AddTotalPoints(GetGoalPoints());

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
        return $"EternalGoal:{GetName()},{GetDescription()},{GetGoalPoints()}";
    }
}