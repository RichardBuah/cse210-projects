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
        int verse = 1;
        int endVerse = 0;

        string text = "Write down the expression for the iso-potentials and the streamline starting with the general solutions given in the course notes and inserting the appropriate well rates and locations given.";

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
            if (startLoop <= shaffleList.Count()-1)
            {
                int numHide = shaffleList[startLoop];
                startLoop += 1;
                script1.HideRandomWords(numHide);
                if (stopConsoleNow)
                {
                    status = "Quit";
                }
            }
            else 
            {
                status = "Quit";
            }
        }
    }
}