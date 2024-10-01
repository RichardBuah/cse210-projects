using System;

public class Resume
{
    public string _name;

    public List<Job> _jobList = new List<Job>();

    // Display
    public void DisplayResume(){

        Console.WriteLine($"Name: {_name}");  
        Console.WriteLine("Job History:");      
        
        foreach(Job jobs in _jobList){
            jobs.DisplayJobDescription();
        }

    }
}