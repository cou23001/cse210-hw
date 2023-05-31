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

    public string GetStandardDetails()
    {
        return ($"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}, {GetTime()} hrs.\nAddress:\n{GetAddress()}");
    }

    public string GetShortDescription()
    {
        return ($"Type: {GetType()}\nTitle: {GetTitle()}\nDate: {GetDate()}\n");
    }
}