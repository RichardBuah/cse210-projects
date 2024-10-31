using System;

public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string name, string date, int minutes, int laps) : base(name, date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        double d = (_laps*50)*0.001;
        return d;
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