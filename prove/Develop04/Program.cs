using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        List<string> menuDisplay = new List<string>()
        {
            "Start Breathing Activity",
            "Start Reflecting Activity",
            "Start Listing Activity"
        };
        do
        {
            userSelection = MenuSelector(menuDisplay);
            switch (userSelection)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartActivity();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.StartActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartActivity();
                    break;
                default:
                    if (userSelection != menuDisplay.Count() + 1)
                    {
                        Console.WriteLine($"{userSelection} is not a valid option, hit ENTER to try again.");
                        Console.ReadLine();
                    }
                    break;
            }
        } while (userSelection != menuDisplay.Count() + 1);
    }
    static int MenuSelector(List<string> menuOptions)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < menuOptions.Count(); i++)
        {
            Console.WriteLine($"    {i + 1}) {menuOptions[i]}");
        }
        Console.WriteLine($"    {menuOptions.Count() + 1}) Quit");
        Console.Write("Select A Choice From The Menu: ");
        return int.Parse(Console.ReadLine());
    }
}