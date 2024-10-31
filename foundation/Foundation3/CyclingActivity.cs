using System;

public class CyclingActivity : Activity 
{
    private int _rpm;
    private int _tyreDiameter;
    public CyclingActivity(string name, string date,int minutes, int rpm, int tyreDiameter) : base(name, date, minutes)
    {
        _rpm = rpm;
        _tyreDiameter = tyreDiameter;
    }
    public override double GetDistance()
    {
        double d = _rpm*3.142*_tyreDiameter;
        double df = (d*_minutes)/1000;
        return df;
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