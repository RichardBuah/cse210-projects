using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // Creating a menu for the cool user experience
        int openMenu = 0;

        // Creating all Instances
        PrommptGenerator autoprm = new PrommptGenerator();
        Journal clientJournal = new Journal();

        while(openMenu == 0){
            Console.WriteLine("Please choose one option from the Menu below\n1. New Entry\n2. Display Entries\n3. Save Journal to a file\n4. Load Journal from a file\n5. close application");
            openMenu = int.Parse(Console.ReadLine());

            // Menu Option 1
            if (openMenu == 1){        
                // Console.WriteLine("Hello Develop02 World!");
                // Creating Second Instance
                Entry clientEntry = new Entry();
                DateTime currentDateTime = DateTime.Now;
                clientEntry._date = currentDateTime.ToShortDateString();
                clientEntry._promptText = autoprm.GetRandomPrompt();
                
                // Asking for client Entry
                Console.WriteLine($"{clientEntry._promptText}");
                Console.WriteLine("Answer Below >>>>");
                clientEntry._entryText = Console.ReadLine();
                clientJournal.AddEntry(clientEntry);
                openMenu = 0;
            }

            else if (openMenu == 2){
                // Displaying the journal
                clientJournal.DisplayAll();
                openMenu = 0;
            }

            else if (openMenu == 3){
                Console.WriteLine("Provide the name of the file you are saving to.");
                string file = Console.ReadLine();
                clientJournal.SaveToFile($@"C:\Users\rbbua\OneDrive\Desktop\BYUI\CSE210\Git resipository\cse210-projects\prove\Develop02\{file}.csv");
                openMenu = 0;
            }

            else if (openMenu == 4){
                // Loading file
                Console.WriteLine("Enter the name of the file you are loading from.");
                string file = Console.ReadLine();
                clientJournal.LoadFromFile($@"C:\Users\rbbua\OneDrive\Desktop\BYUI\CSE210\Git resipository\cse210-projects\prove\Develop02\{file}.csv");
                openMenu = 0;
            }
            else{
                openMenu = -1;
                Console.WriteLine("Aplication Closed");
            }
        }
    }
}