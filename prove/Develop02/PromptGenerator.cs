using System;
using System.Collections.Generic;

public class PrommptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        // Creating First Instance for Prompt generation
        PrommptGenerator autoPrompt = new PrommptGenerator();
        autoPrompt._prompts.Add("Where did you have your first coffe?");
        autoPrompt._prompts.Add("How was your wife's day at work?");
        autoPrompt._prompts.Add("Did you enjoy launch?");
        autoPrompt._prompts.Add("Did you bump into any road rage today?");
        autoPrompt._prompts.Add("Who did you meet today?");
        autoPrompt._prompts.Add("Did you complete all task at work?");
        autoPrompt._prompts.Add("Did you pray befor leaving home?");
        autoPrompt._prompts.Add("How much money did you make working today?");
        autoPrompt._prompts.Add("What life lesson did you learn today?");
        autoPrompt._prompts.Add("Did you enjoy lunch?");
        autoPrompt._prompts.Add("How many glasses of water have you had?");
        autoPrompt._prompts.Add("How was you day?");

        int genSize = autoPrompt._prompts.Count;
        Random randomPromptGen = new Random();
        int ranPrompt = randomPromptGen.Next(1,genSize);
        string newPrompt = autoPrompt._prompts[ranPrompt];
        return newPrompt;
    }
}