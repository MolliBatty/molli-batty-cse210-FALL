using System.ComponentModel;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }
    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType = goalType;
    }

    protected string GetName()
    {
        return _name;
    }
    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    protected string GetDescription()
    {
        return _description;
    }
    private void SetDescription()
    {
        Console.WriteLine($"What is the description of {_name} goal: ");
        _description = Console.ReadLine();
    }


    protected int GetPoints()
    {
        return _points;
    }
    private void SetPoints()
    {
        Console.WriteLine($"What are the points for {_name} goal: ");

        int points;
        while(!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Thats not a number. Try again!");
        }
        _points = points;
    }

    protected bool GetStatus()
    {
        return _complete;
    }
    public virtual string GetConsoleString()
    {
        string completeString = " ";

        if (_complete)
            completeString = "X";

        return $"[{completeString}] {_goalType}, Goal Name: {_name}, Description: {_description}, Points: {_points}";

    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_complete}";
    }

    public abstract int RecordEvent();
}