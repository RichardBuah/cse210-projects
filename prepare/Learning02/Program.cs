using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        // Instance One
        Job job1 = new Job();
        job1._jobtitle = "Software Engineer";
        job1._companyName = "Amazon";
        job1._startDate = 2010;
        job1._endDate = 2014;
        // job1.DisplayJobDescription();

        // Instance Two
        Job job2 = new Job();
        job2._jobtitle = "Data analyst";
        job2._companyName = "Microsoft";
        job2._startDate = 2014;
        job2._endDate = 2018;
        // job2.DisplayJobDescription();

        // Instance three
        Resume resume1 = new Resume();
        resume1._name = "Joseph Smith";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        // Console.Write($"{resume1._jobList[0]._jobtitle}");
        // Resume Display
        resume1.DisplayResume();
        
    }
}