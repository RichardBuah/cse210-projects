// EXCEED REQUIREMENT
// I added the Try and Catch to handle exception errors
// I Made sure no random prompts/questions are selected until they have all been used at least once in that session.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        bool start =true;
        string disp = "===================================================";
        // Creating all Instances
        BreathingActivity breath = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.", 50000);

        ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 50000, 0, ["Who are people that you appreciate?","What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"]);

        ReflectingActivity reflect = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 50000, ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."], ["Why was this experience meaningful to you?","Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"]);
        try {
            while (start == true)
            {
                Console.WriteLine("Menu\nChoose one activity from the menu items below.\n1. Breathing Activity\n2. Listing Activity\n3. Reflectiing Activity\n4. Quit");
                int choice = int.Parse(Console.ReadLine());
                // Breathing Activity
                if (choice == 1)
                {
                    Console.WriteLine(disp);
                    breath.DisplayStartingMessage();
                    breath.Run();
                    breath.DisplayEndingMessage();
                }
                // Listing Activity
                else if(choice == 2)
                {
                    Console.WriteLine(disp);
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                }
                // Reflecting Activity
                else if (choice == 3)
                {
                    Console.WriteLine(disp);
                    reflect.DisplayStartingMessage();
                    reflect.Run();
                    reflect.DisplayEndingMessage();
                }
                // Quit Application
                else 
                {
                    start = false;
                }          
            }
        }
        catch (ArgumentException){
            Console.WriteLine("Invalid argument input.");
        }
        catch (FormatException){
            Console.WriteLine("Invalid type. Check input for string or integer.");
        }
        catch (Exception){
            Console.WriteLine("Something Went wrong. Try again.");
        }
    }
}