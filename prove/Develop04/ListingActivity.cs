internal class ListingActivity : Activity
{
    private string[] _prompts = System.IO.File.ReadAllLines("ListingPrompts");
    private int ResponseCount { get; set; }
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }
    public override void StartActivity()
    {
        Welcome();
        Console.Write($"""
        List as many responses you can to the following prompt:

        ~ {_prompts[RandomGenerator.Next(_prompts.Count())]} ~

        You will begin in...
        """);
        NumberCountdown(5);
        ResponseCount = 0;
        ActivityStartTime = DateTime.Now;
        Console.WriteLine();
        while (DateTime.Now < ActivityStartTime.AddSeconds(Duration))
        {
            Console.Write("> ");
            Console.ReadLine();
            ResponseCount++;
        }
        Console.Write($"You listed {ResponseCount} items.");
        EndingMessage();
    }
}