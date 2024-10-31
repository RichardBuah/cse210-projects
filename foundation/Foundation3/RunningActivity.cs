using System;

public class Runningactivity : Activity
{
    private int _laps;
    public Runningactivity(string name, string date, int minutes, int laps) :base (name, date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        int d = _laps*100/1000;
        return d;
    }
    public override double GetSpeed()
    {
        return _minutes/GetDistance()*60;
    }
    public override double GetPace()
    {
        return 60/GetSpeed();
    }
    
}