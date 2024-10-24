using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;
    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string Getsummary()
    {
        return $"{_studentName} - {_topic}";
    }

}