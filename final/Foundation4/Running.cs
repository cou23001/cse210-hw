public class Running: Activity
{
    private double _distance;

    public Running(string date, double length, double distance): base(date,length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    
    public override double GetSpeed()
    {
        double speed = GetDistance() / GetLength() * 60;
        return Math.Round(speed, 1);
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return Math.Round(pace, 1);
    }

    public override string GetSummary()
    {
        return ($"{GetDate()} {GetType()} ({GetLength()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace:{GetPace()} min per mile");
    }
}