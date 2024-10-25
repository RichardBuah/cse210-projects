using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base() {}
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {}
    public void Run()
    {
        int num = 0;
        Console.WriteLine("Get Ready");
        for(int i = 7000; i > 0; i-=500)
        {
            if (num <= 3)
            {
                Thread.Sleep(500);
                Console.Write(".");
                num ++;
            }
            else 
            {
                Console.Write("\b \b");
                Console.Write("");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Thread.Sleep(500);
                Console.Write("");
                Console.Write("\b \b");
                Console.Write("");
                num = 0;
            }
        }
        Console.WriteLine();

        DateTime startTimmer = DateTime.Now;
        DateTime endTime = startTimmer.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"Breath in ....");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write($"Breath out ....");
            ShowCountDown(5);
            Console.WriteLine();
            Thread.Sleep(1500);
        }
    }
}