using System;

class Job
{
    
    public string _jobTitle;
    public string _Company;
    public int _Startyear;
    public int _EndYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_Company}) {_Startyear}-{_EndYear}");
    }
        
    
}