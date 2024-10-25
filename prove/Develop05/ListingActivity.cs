using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base() 
    {
        _count = 0;
        _prompts = [];
    }
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base (name, description, duration) 
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {
        Console.WriteLine("\nTake a momment to think about the question and type your answers.");
        Console.WriteLine("\nList all you can within the time limit.\n");
        GetRandomPrompt();
        Console.Write("Get Ready ...");
        ShowSpinner(10);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine();
    }
    public void GetRandomPrompt()
    {
        if (_prompts.Count() > 0)
        {
            Random randomPrompt = new Random();
            int index = randomPrompt.Next(_prompts.Count());
            string ranProm = _prompts[index];
            Console.WriteLine(ranProm);
            _prompts.RemoveAt(index);
        }
        else 
        {
            Console.WriteLine($"You have exhusted your Listing Activities for this sesson. Please Choose another activity from the Main Menu.");
        }
        
    }
    public List<string> GetListFromUser()
    {
        List<string> _userList = new List<string>();
        DateTime startTimmer = DateTime.Now;
        DateTime endTime = startTimmer.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            _userList.Add(Console.ReadLine());
            _count++; 
        }
        return _userList;
    }
}