using System.Runtime.Serialization;

class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool complete)
        : base(name, description, points, complete, "SimpleGoal")
    {
        
    }

    public SimpleGoal() : base("SimpleGoal")
    {
        
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            Console.WriteLine("You already did this one!");
            return 0;
        }
        else
        {
            return MarkComplete();
        }

    }
}