using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<string> video1 = new List<string>();
        List<string> video2 = new List<string>();
        List<string> video3 = new List<string>();
        List<string> video4 = new List<string>();

        // For video 1
        video1.Add("Sport Cars"); // title
        video1.Add("F1 Sports"); // Author
        video1.Add("2"); // length in minutes
        video1.Add("The car is nice."); // comments
        video1.Add("Love it looks."); // comments
        video1.Add("Check the speed man."); // comments
        video1.Add("The tyres are huge!"); // comments
        // For video 2
        video2.Add("Sport Cars"); // title
        video2.Add("F2 Sports"); // Author
        video2.Add("2"); // length in minutes
        video2.Add("The car is nice."); // comments
        video2.Add("Love it looks."); // comments
        video2.Add("Check the speed man."); // comments
        video2.Add("The tyres are huge!"); // comments
        // For video 3
        video3.Add("Sport Cars"); // title
        video3.Add("F3 Sports"); // Author
        video3.Add("2"); // length in minutes
        video3.Add("The car is nice."); // comments
        video3.Add("Love it looks."); // comments
        video3.Add("Check the speed man."); // comments
        video3.Add("The tyres are huge!"); // comments
        // For video 4
        video4.Add("Sport Cars"); // title
        video4.Add("F4 Sports"); // Author
        video4.Add("2"); // length in minutes
        video4.Add("The car is nice."); // comments
        video4.Add("Love it looks."); // comments
        video4.Add("Check the speed man."); // comments
        video4.Add("The tyres are huge!"); // comments

        

        foreach(string word in video1)
        {
            Console.WriteLine(word);
        }
    }
}