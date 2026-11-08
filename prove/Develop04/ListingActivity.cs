class ListingActivity: BaseActivity
{

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Name a few candies you like.",
        "Name a few people in your life who have helped you to grow."
    };
    private Random _random = new Random();
    public ListingActivity(string activityName, string description): base(activityName, description)
    {
        
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        int index = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        RunCountDownMessage("You may begin in", 5);
        Console.WriteLine(_prompts[index]);
        
        StartTimer();
        List<string> items = new List<string>();

        while (!HasTimerExpired())
        {
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items!");
        RunSpinnerMessage("...", 4);
        EndActivity();
    }
}