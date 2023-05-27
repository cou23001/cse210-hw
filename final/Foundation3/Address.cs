public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipcode;

    public Address(string street, string city, string state, string country, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipcode = zipcode;
    }
    
    public bool IsUSA()
    {
        if (_country == "USA")
            return true;
        else 
            return false;
    }

    public override string ToString()
    {
        return ($"{_street}\n{_city}, {_state}\n{_country}, {_zipcode}");
    }
}