using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public int GoalCount
    {
        get { return goals.Count; }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void ListGoalNames()
    {
        int count = 1;
        foreach (var goal in goals)
        {
            Console.WriteLine($"{count}. {goal.ShortName}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;
        foreach (var goal in goals)
        {
            Console.WriteLine($"{count}. {goal.GetGoalDetails()}");
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"Total Points: {score}");
    }

    public void CreateGoal(string goalType, string shortName, string description, int points, int target = 0, int bonus = 0)
    {
        Goal goal;
        switch (goalType.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(shortName, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(shortName, description, points);
                break;
            case "checklist":
                goal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            default:
                throw new ArgumentException("Invalid goal type.");
        }
        goals.Add(goal);
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber < 1 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        var goal = goals[goalNumber - 1];
        int points = goal.RecordEvent();
        score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points.");
        Console.WriteLine($"You now have {score} points.");
    }

    public void SaveGoals(string filename)
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
        using (StreamWriter file = new StreamWriter(path))
        {
            foreach (var goal in goals)
            {
                file.WriteLine($"{goal.GetType().Name},{goal.ShortName},{goal.Description},{goal.Points},{goal.Completed}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    file.WriteLine($"{checklistGoal.Target},{checklistGoal.Bonus},{checklistGoal.AmountCompleted}");
                }
            }
            file.WriteLine($"Score,{score}");
        }
    }

    public void LoadGoals(string filename)
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
        using (StreamReader file = new StreamReader(path))
        {
            goals.Clear();
            string line;
            while ((line = file.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts[0] == "Score")
                {
                    score = int.Parse(parts[1]);
                }
                else
                {
                    string goalType = parts[0];
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool completed = bool.Parse(parts[4]);

                    Goal goal;
                    if (goalType == "SimpleGoal")
                    {
                        goal = new SimpleGoal(shortName, description, points);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        goal = new EternalGoal(shortName, description, points);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        line = file.ReadLine(); 
                        var checklistParts = line.Split(',');
                        int target = int.Parse(checklistParts[0]);
                        int bonus = int.Parse(checklistParts[1]);
                        int amountCompleted = int.Parse(checklistParts[2]);
                        goal = new ChecklistGoal(shortName, description, points, target, bonus);
                        ((ChecklistGoal)goal).AmountCompleted = amountCompleted;
                    }
                    else
                    {
                        continue;
                    }
                    goal.Completed = completed;
                    goals.Add(goal);
                }
            }
        }
    }
}

