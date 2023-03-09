internal class ReflectingActivity : Activity
{
    private string[] _prompts = System.IO.File.ReadAllLines("ReflectionPrompts");
    private string[] _questions = System.IO.File.ReadAllLines("ReflectionQuestions");
    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }
    public override void StartActivity()
    {
        Welcome();
        Console.WriteLine($"""
        Consider the following prompt:

        ~ {_prompts[RandomGenorator.Next(_prompts.Count())]} ~

        When you have something in mind press ENTER to contiue.
        """);
        Console.ReadLine();
        Console.Clear();
        Console.Write(_questions[RandomGenorator.Next(_questions.Count())]);
        ActivityStartTime = DateTime.Now;
        while (DateTime.Now < ActivityStartTime.AddSeconds(Duration))
        {
            WaitingAnimation();
        }
        EndingMessage();
    }
}