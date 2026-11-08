using System.Runtime.InteropServices;

class BaseActivity
{
    private int _duration;
    private DateTime _endTime;
    private string _activityName;
    private string _description;
    public BaseActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _duration = 30;  // Replace with call to ObtainDuration();
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // for(int i = 0; i < seconds; i++)
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");

        }
        Console.CursorVisible = true;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like your session to go for?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        RunSpinnerMessage("Get Ready...", 3);
    }

    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("Well Done!");
        RunSpinnerMessage("Well Done!", 3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity");
        RunSpinnerMessage("...", 3);
    }
}