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
            BreatheIn(4);
            BreatheOut(6);
        }
    }

    private void BreatheIn(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear(); 
            Console.WriteLine($"Breathe in...{new string('.', i)} {i}");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Breathe in...0");
        Thread.Sleep(1000);
    }

    private void BreatheOut(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear(); 
            Console.WriteLine($"Breathe out...{new string('.', 6 - i)} {i}");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Breathe out...0");
        Thread.Sleep(1000);
    }
}
