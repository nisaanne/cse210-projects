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
            Console.WriteLine("Prepare to Breathe in...");
            Countdown(5);
            Console.WriteLine("Breathe in...");
            SlowBreathingAnimation(5);

            Console.WriteLine("Prepare to Breathe out...");
            Countdown(5);
            Console.WriteLine("Breathe out...");
            SlowBreathingAnimation(5);
        }
    }

    private void SlowBreathingAnimation(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            Console.Write("+");
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
            Console.Write("-");
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
        }
        Console.WriteLine();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); 
        }
    }
}


