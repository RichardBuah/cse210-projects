using System;

public class MathAssignment : Assignment
{
    private string _textbookSession;
    private string _problems;

    public MathAssignment(): base()
    {
        _textbookSession = "Unknown";
        _problems = "Unknown";
    }
    public MathAssignment(string name, string topic, string textbookSession, string problems): base(name, topic)
    {
        _textbookSession = textbookSession;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSession} {_problems}";
    }
}