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
        return _laps*100*0.001;
    }
    public override double GetSpeed()
    {
        return GetDistance()/_minutes*60;
    }
    public override double GetPace()
    {
        return 60/GetSpeed();
    }
    
}