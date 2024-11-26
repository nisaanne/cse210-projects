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
            OldAnimationPause(5);
            Console.WriteLine("Breathe out...");
            OldAnimationPause(5);
        }
    }

    private void OldAnimationPause(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the - character
        }
        Console.WriteLine();
    }

    private void SpinningPause(int seconds)
    {
        char[] spinner = new char[] { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[counter % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
            counter++;
        }
        Console.WriteLine();
    }
}


