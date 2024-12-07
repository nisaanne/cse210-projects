using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager tracker = new GoalManager();
        
        while (true)
        {
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    CreateGoal(tracker);
                    break;
                
                case "2":
                    tracker.ListGoalDetails();
                    break;
                
                case "3":
                    Console.Write("Enter filename to save progress (e.g., goals.txt): ");
                    string saveFile = Console.ReadLine();
                    tracker.SaveGoals(saveFile);
                    break;
                
                case "4":
                    Console.Write("Enter filename to load progress (e.g., goals.txt): ");
                    string loadFile = Console.ReadLine();
                    tracker.LoadGoals(loadFile);
                    break;
                
                case "5":
                    RecordGoalEvent(tracker);
                    break;

                case "6":
                    tracker.DisplayPlayerInfo();
                    break;
                
                case "7":
                    return;
                
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public static void RecordGoalEvent(GoalManager tracker)
    {
        while (true)
        {
            Console.WriteLine("List of Goals:");
            tracker.ListGoalNames();
            Console.Write("What goal did you accomplish? Enter the list number: ");
            if (int.TryParse(Console.ReadLine(), out int goalNumber))
            {
                if (goalNumber >= 1 && goalNumber <= tracker.GoalCount)
                {
                    tracker.RecordEvent(goalNumber);
                    break;
                }
            }
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }

    public static void CreateGoal(GoalManager tracker)
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                CreateSimpleGoal(tracker);
                break;
            case "2":
                CreateEternalGoal(tracker);
                break;
            case "3":
                CreateChecklistGoal(tracker);
                break;
            default:
                Console.WriteLine("Invalid option. Returning to main menu.");
                break;
        }
    }

    public static void CreateSimpleGoal(GoalManager tracker)
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        tracker.CreateGoal("simple", shortName, description, points);
    }

    public static void CreateEternalGoal(GoalManager tracker)
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        tracker.CreateGoal("eternal", shortName, description, points);
    }

    public static void CreateChecklistGoal(GoalManager tracker)
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        tracker.CreateGoal("checklist", shortName, description, points, target, bonus);
    }
}


