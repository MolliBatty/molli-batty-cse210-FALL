class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal (string name, string description, int points, bool complete, int numberOfCompletions) 
        : base (name, description, points, complete, "EternalGoal")
    {
       _numberOfCompletions = numberOfCompletions;
    }

    public EternalGoal() : base ("EternalGoal")
    {
       _numberOfCompletions = 0;  
    }


    public override int RecordEvent()
    {
        _numberOfCompletions ++;
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()}, Completed {_numberOfCompletions} times";
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}|{_numberOfCompletions}";
    }
}