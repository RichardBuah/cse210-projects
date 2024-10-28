using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(): base()
    {
        _isComplete = false;
    }
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"S, {IsComplete()}, {GetShortName()}, {GetDescription()}, {_points}";
    }
}