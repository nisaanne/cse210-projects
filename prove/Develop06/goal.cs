public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _completed;

    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _completed = false;
    }

    public string ShortName
    {
        get => _shortName;
    }

    public string Description
    {
        get => _description;
    }

    public int Points
    {
        get => _points;
    }

    public bool Completed
    {
        get => _completed;
        protected set => _completed = value;
    }

    public abstract int RecordEvent();

    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    public string GetCheckbox()
    {
        return _completed ? "[X]" : "[ ]";
    }

    public override string ToString()
    {
        return $"{GetCheckbox()} {_shortName}: {_description} - Points: {_points}";
    }
}
