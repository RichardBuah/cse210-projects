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
        return _laps*50/1000;
    }
    public override double GetSpeed()
    {
        return ((_minutes/GetDistance())*60);
    }
    public override double GetPace()
    {
        return (60/GetSpeed());
    }
}