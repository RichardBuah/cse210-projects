using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public string GetDestination()
    {
        return _country;
    }
    public string GetDisplayText()
    {
        return $"{_streetAddress}, {_city}\n{_stateProvince}, {_country}";
    }
}