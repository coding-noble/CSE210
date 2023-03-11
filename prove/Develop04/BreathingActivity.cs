internal class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void StartActivity()
    {
        Welcome();
        ActivityStartTime = DateTime.Now;
        while (DateTime.Now < ActivityStartTime.AddSeconds(Duration))
        {
            Console.Write("\n\nBreath In...");
            NumberCountdown(5);
            Console.Write("\nNow Breath Out...");
            NumberCountdown(5);
        }
        EndingMessage();
    }
}