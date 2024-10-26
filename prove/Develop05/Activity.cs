using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity()
    {
        _name = "unknown";
        _description = "Unknown";
        _duration = 30000;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Acticity.");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("\nHow Long do you want to spend on this activity in seconds.");
        _duration = int.Parse(Console.ReadLine());   
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_name} Activity");
        Thread.Sleep(3000);
        Console.WriteLine($"\nThis {_name} activity lasted for {_duration} seconds.");
        Thread.Sleep(2000);
        Console.WriteLine("Done.\n");
        Thread.Sleep(1000);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("|");
        spinner.Add("\\");
        spinner.Add("-");
        spinner.Add("/");
        int ind = 0;
        DateTime startTimmer = DateTime.Now;
        DateTime endTime = startTimmer.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            if (ind < spinner.Count())
            {
                Console.Write(spinner[ind]);
                Thread.Sleep(100);
                Console.Write("\b \b");
                ind++;
            }
            else
            {
                ind = 0;
            }
        }         
    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTimmer = DateTime.Now;
        DateTime endTime = startTimmer.AddSeconds(seconds);
        while (DateTime.Now < endTime)
            {
                Console.Write("\b \b");
                Console.Write($"{seconds-1}");
                Thread.Sleep(1000);
                seconds--;
            }
    }
    

}