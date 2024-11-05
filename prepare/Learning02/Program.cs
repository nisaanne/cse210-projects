using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2015";
        job1._endYear = "2018";

        
        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Apple";
        job2._startYear = "2018";
        job2._endYear = "2021";

        
        Resume myResume = new Resume();
        myResume._name = "Venisa McAllister";

        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

       
        myResume.Display();

        
        Console.WriteLine($"First job title: {myResume._jobs[0]._jobTitle}");
    }
}
