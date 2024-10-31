using System;
using Microsoft.VisualBasic;

public abstract class Activity
{
    private string _name;
    private string _date;
    protected double _minutes;
    public Activity(string name, string date, int minutes)
    {
        _name = name;
        _date = date;
        _minutes = minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummaryString(double distance, double speed, double pace)
    {
        return $"{_date} {_name} ({_minutes} min): Distance {distance} Km, Speed:{speed} Kph, Pace: {pace} min per Km)";
    }
}