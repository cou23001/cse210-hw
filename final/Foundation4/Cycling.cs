public class Cycling: Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed): base(date,length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = GetSpeed() * GetLength() / 60;
        return Math.Round(distance,1);
    }
    public override double GetSpeed()
    {
        return _speed;
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