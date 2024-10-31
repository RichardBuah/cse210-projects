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
    public string GetSummaryString()
    {
        return $"{_date} {_name} ({_minutes} min): Distance {Math.Round(GetDistance(), 4)} Km, Speed:{Math.Round(GetSpeed(), 4)} Kph, Pace: {Math.Round(GetPace(), 4)} min per Km";
    }
}