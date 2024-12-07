public abstract class Goal
{
    public string ShortName { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public Goal(string shortName, string description, int points)
    {
        ShortName = shortName;
        Description = description;
        Points = points;
        Completed = false;
    }

    public abstract int RecordEvent();

    public string GetCheckbox()
    {
        return Completed ? "[X]" : "[ ]";
    }

    public virtual string GetGoalDetails()
    {
        return $"{GetCheckbox()} {ShortName}: {Description}";
    }
}
