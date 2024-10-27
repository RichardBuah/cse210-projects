using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
}