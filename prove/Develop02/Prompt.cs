using System;
public class Prompt
{
    static List<string> _prompts = new List<string>()
    {
        "What was the most peaceful moment during the day?",
        "Describe something you learned today that you didn't know before.",
        "Would you change any of the decisions you made today?",
        "How were your meals today? Do you feel nourished?",
        "What frightened you today?",
        "Who do you wish you had talked to today? How do they improve your life?",
        "Describe the moments of frustration you felt today. How would your day have changed if those moments were different?",
        "If you'd had another hour during the day, how would you have spent it?",
        "Did something (or someone) empower you today?",
        "Did you stop yourself from doing something you enjoy today? Why or why not?",
        "Reflect on how your body feels. Where are you storing your stress? What put it there?",
        "Who helped you the most today? Who did you help the most?",
        "Describe your day from another person's perspective. Is it different from yours?"
    };
    static Random _random = new Random();
    public string _promptText = _prompts[_random.Next(0, (_prompts.Count - 1))];
}