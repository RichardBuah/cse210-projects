using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public bool GetDestination()
    {
        return true;
    }
    public string GetDisplayText()
    {
        return $"{_streetAddress}, {_city}\n{_stateProvince}, {_country}";
    }
}