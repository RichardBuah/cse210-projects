using System;
using System.Collections.Generic;
using System.Diagnostics;

/* CREATIVITY */
/* Included a functionality to the hide method in the Word class to replace the words with dashes of the exact characters of the word. For instance if a word "Gone" has 4 characrters the hidden word will be made of 4 dash lines.*/
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");\
        string status = "";        
        string book = "Romans";
        int chapter = 1;
        int verse = 13;
        int endVerse = 0;
        string text = "But I do not want you to be unaware, brothers, that many times I have intended to come to you—but I have been prevented until now—in order that I might acquire some fruitage also among you just as among the rest of the nations.";

        string[] texts = text.Split(" ");
        Reference refRence = new Reference(book, chapter, verse, endVerse);
        Scripture script1 = new Scripture(refRence, text);
        HashSet<int> _randomShaffle = new HashSet<int>();
        int max = texts.Count()+1;
        Random generator = new Random();
        while (_randomShaffle.Count < (max - 1))
        {
            int gen = generator.Next(0, max-1);
            if (!_randomShaffle.Contains(gen))
            {
                _randomShaffle.Add(gen);
            }
        }
        List<int> shaffleList = _randomShaffle.ToList<int>();
        int startLoop = 0;
        
        while (status == "")
        {
            Console.Clear();
            Console.WriteLine(refRence.GetDisplayString());
            Console.WriteLine(script1.GetDisplayText());
            bool stopConsoleNow = script1.IsCompletelyHidden();
            Console.WriteLine("Please press ENTER key to continue or type Quit to close the application");
            status = Console.ReadLine();
            if (startLoop < shaffleList.Count()-1 && stopConsoleNow == false)
            {
                int numHide = shaffleList[startLoop];
                script1.HideRandomWords(numHide);
                startLoop += 1;
            }
            else 
            {
                int numHide = shaffleList[startLoop];
                script1.HideRandomWords(numHide);
                Console.Clear();
                Console.WriteLine(refRence.GetDisplayString());
                Console.WriteLine(script1.GetDisplayText());
                status = "Quit";
            }
        }
    }
}