using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        // Instance One Running Activity
        SwimmingActivity run = new SwimmingActivity("Running", "03 Nov 2024", 30, 5);
        Console.WriteLine(run.GetSummaryString(run.GetDistance(), run.GetSpeed(), run.GetPace()));
    }
}