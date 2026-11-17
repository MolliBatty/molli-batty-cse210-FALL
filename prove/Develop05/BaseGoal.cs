using System.ComponentModel;

class BaseGoal
{
    private string _name;
    private string _description;
    public BaseGoal()
    {
        SetName();
    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    public virtual string GetConsoleString()
    {
        return $"Goal Name: {_name}";
    }
}