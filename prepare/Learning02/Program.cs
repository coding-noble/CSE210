using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Missionary";
        job1._company = "Church of Jesus Christ of Laterday Saints";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "WB Games";
        job2._startYear = 2025;
        job2._endYear = 2050;

        Resume myResume = new Resume();
        myResume._name = "Miles Noble";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}