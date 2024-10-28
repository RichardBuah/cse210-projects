using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");
        GoalManager manage = new GoalManager();
        bool start = true;
        
        while (start)
        {
            manage.Start();
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                manage.CreateGoal();
            }
            else if (choice == 2)
            {
                manage.RecordEvent();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Goal Summary");
                manage.ListGoalDetails();
            }
            else if (choice == 4)
            {
                manage.SaveGoals();
            }
            else if (choice == 5)
            {
                manage.LoadGoals();
            }
            else
            {
                start = false;
            }
        }
    }
}