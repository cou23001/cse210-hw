public abstract class Activity
{
    private string _date;
    private int _lengthActivity;

    public Activity(string date, int length)
    {
        _date = date;
        _lengthActivity = length;
    }
    public string GetDate()
    {
        return _date;
    }

    public int GetLengthActivity()
    {
        return _lengthActivity;
    }
    public abstract string GetSummary();
    public abstract int GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}