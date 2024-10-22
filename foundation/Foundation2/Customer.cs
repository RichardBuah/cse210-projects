using System;

public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool GetDestination(string address)
    {
        bool yesOrNo = false;
        if (address.ToLower() == "us" || address.ToLower() == "usa")
        {
            yesOrNo = true;
        }
        else 
        {yesOrNo = false;} 
        return yesOrNo;
    }
    public string GetDisplayText()
    {
        return $"{_name}";
    }
}