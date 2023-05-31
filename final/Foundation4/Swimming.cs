public class Swimming: Activity
{
    private int _swimmingLaps;
    public Swimming(string date, double length, int number): base(date,length)
    {
        _swimmingLaps = number;
    }
    public int GetSwimmingLaps()
    {
        return _swimmingLaps;
    }
    public override double GetDistance()
    {
        double distance = (double) GetSwimmingLaps() * 50 / 1000;
        return Math.Round(distance,1);
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