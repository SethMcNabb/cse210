using System;

public class Job 
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 1900;
    public int _endYear = 2024;
    public void DisplayJobDetails() 
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}