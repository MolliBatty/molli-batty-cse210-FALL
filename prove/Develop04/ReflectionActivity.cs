using System.Data;

class ReflectionActivity : BaseActivity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time you had a delicious meal and describe it.",
        "Think of a time when you went on a trip and had a good time."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();

    public ReflectionActivity(string activityName, string description): base(activityName, description)
    {
        
    }

    public void RunActivity()
    {
        StartActivity();
        StartTimer(); 

        Console.WriteLine("Consider this prompt:");
        int index = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

        while (!HasTimerExpired())
        {
           int questionIndex = _random.Next(_questions.Count);
           Console.WriteLine(_questions[questionIndex]); 
           RunSpinnerMessage("Think about it", 8);
        }

        EndActivity();
    }
}