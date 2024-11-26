public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        for (int i = 0; i < duration; i += 10)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(5);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(5);
        }
    }
}

