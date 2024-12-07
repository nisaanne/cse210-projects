using System;
using System.Threading;

public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    public int Target { get; set; }
    public int Bonus { get; set; }
    private bool bonusAwarded;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        AmountCompleted = 0;
        Target = target;
        Bonus = bonus;
        bonusAwarded = false;
    }

    public override int RecordEvent()
    {
        AmountCompleted++;
        if (AmountCompleted >= Target && !bonusAwarded)
        {
            Completed = true;
            bonusAwarded = true;
            DisplayStars();
            return Points + Bonus;
        }
        else if (AmountCompleted >= Target)
        {
            return Points;
        }
        return Points;
    }

    public override string GetGoalDetails()
    {
        return $"{GetCheckbox()} {ShortName} - Completed {AmountCompleted}/{Target} times";
    }

    private void DisplayStars()
    {
        string[] stars = { "*", "**", "***", "****", "*****", "******", "*******" };
        foreach (var star in stars)
        {
            Console.Clear();
            Console.WriteLine(star);
            Thread.Sleep(200);
        }
        Console.WriteLine("Congratulations! Checklist Goal Completed!");
    }
}

