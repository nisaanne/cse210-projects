public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    public int Target { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        AmountCompleted = 0;
        Target = target;
        Bonus = bonus;
    }

    public override int RecordEvent()
    {
        AmountCompleted++;
        if (AmountCompleted >= Target)
        {
            Completed = true;
            return Points + Bonus;
        }
        return Points;
    }

    public override string GetGoalDetails()
    {
        return $"{base.GetGoalDetails()} - Completed {AmountCompleted}/{Target} times";
    }
}
