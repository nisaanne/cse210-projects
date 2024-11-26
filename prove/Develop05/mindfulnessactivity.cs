using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    private string _name;
    private string _description;
    private int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        SpinningPause(3);

        PerformActivity();

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        SpinningPause(3);
    }

    protected abstract void PerformActivity();

    protected void SpinningPause(int seconds)
    {
        char[] spinner = new char[] { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[counter % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
            counter++;
        }
        Console.WriteLine();
    }

    protected int GetDuration()
    {
        return _duration;
    }
}
