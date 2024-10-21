using System;

public class Customer
{
    private string _name;
    private Address _address;
    public bool GetDestination()
    {
        bool yesOrNo = new Address().GetDestination();
        return yesOrNo;
    }
}