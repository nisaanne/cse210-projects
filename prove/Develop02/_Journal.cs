using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;

public class _Journal
{
    private List<_Entry> _entries = new List<_Entry>();
    private List<string> _prompts = new List<string>
    {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?" 
    };
public void WriteNewEntry()
{
    var random = new Random();
    string prompt = _prompts[random.Next(_prompts.Count)];
    Console.WriteLine(prompt);
    string response = Console.ReadLine();

    _Entry entry = new _Entry();
    entry._prompt = prompt;
    entry._response = response;
    entry._date = DateTime.Now.ToString("yyyy-MM-dd");

    _entries.Add(entry);
}

public void DisplayJournal()
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No journal entries to display.");
    }
    else
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
}

public void SaveJournal(string filename)
{
    
    string path = Path.Combine(Directory.GetCurrentDirectory(), filename);
    using (StreamWriter writer = new StreamWriter(path))
    {
        foreach (var entry in _entries)
        {
            writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
        }
    }
    Console.WriteLine($"Journal saved to: {path}");
}
public void LoadJournal(string filename)
{
    string path = Path.Combine(Directory.GetCurrentDirectory(), filename);
    _entries.Clear();
    using (StreamReader reader = new StreamReader(path))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            _Entry entry = new _Entry();
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry._date = parts[0];
            _entries.Add(entry);
            _entries.Add(entry); Console.WriteLine($"Loaded Entry: {entry._date} - {entry._prompt}: {entry._response}");

        }
    }
    Console.WriteLine($"Journal loaded from: {path}");
}
}
public class _Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}: {_response}");
    }
}