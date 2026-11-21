class ChecklistGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool complete, int numberOfCompletions, int maxGoals, int bonusPoints) 
        : base (name, description, points, complete, "ChecklistGoal")
    {
        _numberOfCompletions = numberOfCompletions;
        _maxGoals = maxGoals;
        _bonusPoints = bonusPoints;

    }

    public ChecklistGoal() : base ("ChecklistGoal")
    {
       _numberOfCompletions = 0;  
       ObtainMaxGoal();
       ObtainBonusPoints();
    }

    private void ObtainMaxGoal()
    {
        Console.WriteLine($"How many times do you need to complete {GetName()}: ");
        int max;
        while(!int.TryParse(Console.ReadLine(), out max))
        {
            Console.WriteLine("That is not a number. Try again!");
        }
        _maxGoals = max;
       
    }

    private void ObtainBonusPoints()
    {
        Console.WriteLine($"How many bonus points do you get for finishing {GetName()}: ");
        int bonus;
        while(!int.TryParse(Console.ReadLine(), out bonus))
        {
            Console.WriteLine("That is not a number. Please try again!");
        }
        _bonusPoints = bonus;
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            Console.WriteLine("You already did this one!");
            return 0;
        }
        _numberOfCompletions++;
        if(_numberOfCompletions == _maxGoals)
        {
            return MarkComplete() + _bonusPoints;
        }
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()}, Completed {_numberOfCompletions}/{_maxGoals} times";
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}|{_numberOfCompletions}|{_maxGoals}|{_bonusPoints}";
    }
}