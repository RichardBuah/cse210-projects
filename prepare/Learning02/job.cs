using System;

public class Job
{
    public string _jobtitle;
    public string _companyName;
    public int _startDate;
    public int _endDate;

    public void DisplayJobDescription() 
    {
        Console.WriteLine($"{_jobtitle} ({_companyName}) {_startDate}-{_endDate}");
    }
}