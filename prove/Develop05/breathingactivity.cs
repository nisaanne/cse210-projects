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
            Console.Write("Breathe in...");
            Countdown(5);
            Console.Write("Breathe out...");
            Countdown(5);
        }
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000); // One second pause between countdown numbers
            Console.Write("\b\b"); // Erase the previous number
        }
        Console.WriteLine(" 0");
    }
}
