using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity() : base ()
    {
        _prompts = [];
        _questions = [];
    }
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {
        Console.Write("Get Ready ...");
        ShowSpinner(5);
        Console.WriteLine();
        DateTime startTimmer = DateTime.Now;
        DateTime endTime = startTimmer.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            if (_prompts.Count() > 0)
            {
                displayPrompt();
                ShowSpinner(3);
                displayQuestions();
                ShowSpinner(8);
                Console.Write("");
            }
            else 
            {
                Console.WriteLine("You have exhusted your Reflecting Activities for this sesson. Please Choose another activity from the Main Menu.");
                _duration = Convert.ToInt32((DateTime.Now - startTimmer).TotalSeconds);
                Console.Write("");
                break;
            }
        }
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count());
        string ranProm = _prompts[index];
        _prompts.RemoveAt(index);
        return ranProm;
    }
    public string GetRandomQuestion()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_questions.Count());
        string ranProm = _questions[index];
        _questions.RemoveAt(index);
        return ranProm;
    }
    public void displayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void displayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}