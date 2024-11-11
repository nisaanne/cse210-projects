using System;

public class _Entry
{
  public string _prompt;
  public string _response;
  public string _date;
  public string _currentGoal; 
public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Current Goal: {_currentGoal}");

        Console.WriteLine();
    }

}