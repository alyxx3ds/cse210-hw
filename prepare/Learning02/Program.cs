using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTittle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._jobTittle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2022;
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}