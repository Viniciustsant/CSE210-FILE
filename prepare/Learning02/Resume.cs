using System;
using System.Collections.Generic;


public class Resume
{
    public string _personName;
    public List<Job> _jobs;

    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personName} \nJobs:");
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

}