using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        // Instances
        List<Activity> list = new List<Activity>();
        Runningactivity run = new Runningactivity("Running", "09 Nov 2023", 30, 10);
        SwimmingActivity swim = new SwimmingActivity("Swim", "03 Nov 2024", 40, 5);
        CyclingActivity cycle = new CyclingActivity("Cycling", "09 May 2028", 20, 240, 0.3);
        list.Add(run);
        list.Add(swim);
        list.Add(cycle);
        foreach(Activity item in list)
        {
            Console.WriteLine(item.GetSummaryString());
        } 
    }
}