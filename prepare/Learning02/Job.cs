namespace Learning02;

public class Job
{
    public string _jobTittle;
    public string _company;
    public int _startYear;
    public int _endYear;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        
        Console.WriteLine($"{_jobTittle} ({_company}) {_startYear}-{_endYear}");
    }
    }