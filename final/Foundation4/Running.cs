public class Running: Activity
{
    private int _distance;

    public Running(string date, int length, int distance): base(date,length)
    {
        _distance = distance;
    }
    public override int GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetLengthActivity() * 60;
    }
    public override double GetPace()
    {
        return GetLengthActivity() / GetDistance();
    }
    public override string GetSummary()
    {
        return ($"{GetDate()} {GetType()} ({GetLengthActivity()})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace:{GetPace()} min per mile");
    }
}