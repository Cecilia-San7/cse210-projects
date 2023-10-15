using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._Company ="Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._Startyear = 2019;
        job1._EndYear = 2022;

        // Console.WriteLine(job1._Company);

        Job job2 = new Job();
        job2._Company = "Apple";
        job2._jobTitle = "Manager";
        job2._Startyear = 2022;
        job2._EndYear = 2023;

        // job1.Display(); 

        Resume myResume = new Resume();
        myResume._Name = "Cecilia Santos";
        myResume._Job.Add(job1);
        myResume._Job.Add(job2);

        myResume.Display();

        

        // string title = myResume._Job[0]._jobTitle;
        // Console.WriteLine(title);

    }
}