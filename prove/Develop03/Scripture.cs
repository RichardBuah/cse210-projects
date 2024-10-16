using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }
    public void HideRandomWords(int numberToHide)
    {       
        _words[numberToHide].Hide();
        _words[numberToHide].GetDisplayText();       
    }
    public string GetDisplayText()
    {    
        string displayAll = "";
        foreach(Word word in _words)
        {
            displayAll += $"{word.GetDisplayText()} ";
        }
        return displayAll;
    }
    public bool IsCompletelyHidden()
    {
        bool stopConsole = false;
        foreach(Word word in _words)
        {
            string hidden = word.IsHidden().ToString();
            if (hidden == "true")
            {
                stopConsole = true;
            }
            else 
            {
                stopConsole = false;
            }
        }
        return stopConsole;
    }
}