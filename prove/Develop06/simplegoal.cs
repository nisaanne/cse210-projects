public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points) { }

    public override int RecordEvent()
    {
        Completed = true;
        return Points;
    }

    public override string ToString()
    {
        return $"{GetCheckbox()} {ShortName} - Points: {Points}";
    }
}
