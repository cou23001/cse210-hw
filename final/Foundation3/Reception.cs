public class Reception : Event
{
    private int _rsvpPeople;
    public Reception(string title, string description, string date, string time, Address address): base(title,description,date,time,address)
    {
        _rsvpPeople = 0;
    }

    public void SetRSVP(int num)
    {
        _rsvpPeople = num;
    }

    public int GetRSVP()
    {
        return _rsvpPeople;
    }

    public override string ToString()
    {
        return base.ToString() + ($"RSVP: {_rsvpPeople}");
    }
}