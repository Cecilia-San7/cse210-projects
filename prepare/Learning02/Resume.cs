using System;

class Resume
{
   public string _Name;
   public List<Job> _Job = new List<Job>();


//This is the display method they talk about
    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _Job)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}