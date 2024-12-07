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
            
            if (choice == "1")
            {
                CreateGoal(tracker);
            }
            else if (choice == "2")
            {
                tracker.ListGoalDetails();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save progress (e.g., goals.txt): ");
                string saveFile = Console.ReadLine();
                tracker.SaveGoals(saveFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load progress (e.g., goals.txt): ");
                string loadFile = Console.ReadLine();
                tracker.LoadGoals(loadFile);
            }
            else if (choice == "5")
            {
                RecordGoalEvent(tracker);
            }
            else if (choice == "6")
            {
                tracker.DisplayPlayerInfo();
            }
            else if (choice == "7")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
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

        if (goalTypeChoice == "1")
        {
            CreateSimpleGoal(tracker);
        }
        else if (goalTypeChoice == "2")
        {
            CreateEternalGoal(tracker);
        }
        else if (goalTypeChoice == "3")
        {
            CreateChecklistGoal(tracker);
        }
        else
        {
            Console.WriteLine("Invalid option. Returning to main menu.");
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

