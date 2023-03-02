using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobEmployer = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYr = 2019;
        job1._endYr = 2022;

        Job job2 = new Job();
        job2._jobEmployer = "Apple";
        job2._jobTitle = "Manager";
        job2._startYr = 2022;
        job2._endYr = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Melody C";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
        

    }
}