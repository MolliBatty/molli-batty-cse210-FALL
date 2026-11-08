using System.Data;

class BreathingActivity : BaseActivity
{

    public BreathingActivity(string activityName, string description): base(activityName, description)
    {
        
    }
    public void RunActivity()
    {
        StartActivity();
        StartTimer();

        while(! HasTimerExpired())  // Add when code is ready
        {
            RunCountDownMessage("Breath in", 4);
            RunCountDownMessage("Breath Out", 6);
        }

        EndActivity();
    }
}