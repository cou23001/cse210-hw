public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, Address address, string weather): base(title,description,date,time,address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    
    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: {GetType()}\nWeather: {GetWeather()}";
    }
}