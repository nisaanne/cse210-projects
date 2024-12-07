public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetGoalDetails()
    {
        return base.GetGoalDetails();
    }
}

