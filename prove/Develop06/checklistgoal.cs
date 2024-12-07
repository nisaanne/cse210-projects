using System;
using System.Threading;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _bonusAwarded;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _bonusAwarded = false;
    }

    public int AmountCompleted
    {
        get => _amountCompleted;
        set => _amountCompleted = value;
    }

    public int Target
    {
        get => _target;
    }

    public int Bonus
    {
        get => _bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target && !_bonusAwarded)
        {
            Completed = true;
            _bonusAwarded = true;
            DisplayStars();
            return Points + _bonus;
        }
        else if (_amountCompleted >= _target)
        {
            return Points;
        }
        return Points;
    }

    public override string ToString()
    {
        return $"{GetCheckbox()} {ShortName} - Completed {_amountCompleted}/{_target} times";
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
