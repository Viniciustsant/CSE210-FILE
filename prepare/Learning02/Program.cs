using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job("Customer Support", "Novibet", 2024, 2024);

        

        Job job2 = new Job("Administrative Assistant", "Conserva Jardim", 2022, 2023);

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume myResume = new Resume("Vinicius Santiago");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.DisplayResumeDetails();
    }
}