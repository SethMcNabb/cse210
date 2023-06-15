using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Reliaquest";
        job1._jobTitle = "Product Manager";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Conservice";
        job2._jobTitle = "Associate Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Jhan-Jhan";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}