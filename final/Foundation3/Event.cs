public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }
    public string GetDateTime()
    {
        return ($"{_date} {_time}");
    }

    public string GetAddress()
    {
        return _address.ToString();
    }

    public override string ToString()
    {
        return ($"Title: {GetTitle()}\n{GetDescription()}\n{GetDate()}, {GetTime()} hrs.\n{GetAddress()}\n");
    }

    public string GetStandardDetails()
    {
        return ($"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}, {GetTime()} hrs.\nAddress:\n{GetAddress()}\n");
    }

    public string GetShortDescription()
    {
        return ($"Title: {GetTitle()}\nDate: {GetDate()}\nType: {GetType()}");
    }
}