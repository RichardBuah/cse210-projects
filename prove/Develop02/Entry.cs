using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void entryDisplay()
    {
        Console.WriteLine($"{_date} {_promptText}");
        Console.WriteLine($"> {_entryText}");
    }
}