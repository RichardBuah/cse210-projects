using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries){
            Console.WriteLine($"{entry._date} {entry._promptText}\n> {entry._entryText}");
        }
    }

    public void SaveToFile(string file)
    {
        string pathName = file;
        TextWriter tw = new StreamWriter(pathName, true);
        foreach(Entry entry in _entries){
             tw.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
        }
        tw.Close();
    }

    public void LoadFromFile(string file)
    {
        string pathName = file;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach(string line in lines){
            string[] data = line.Split(",");
            string _date = data[0];
            string _promptText = data[1];
            string _entryText = data[2];
            Console.WriteLine($"{_date} {_promptText}\n> {_entryText}");
        }
    }
}