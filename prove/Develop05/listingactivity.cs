public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] _prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        SpinningPause(5);

        int itemCount = 0;
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Item: ");
            Console.ReadLine();
            itemCount++;
            elapsed += 5;
            SpinningPause(5);
        }

        Console.WriteLine($"You listed {itemCount} items.");
    }
}
