

public class Job
{
    public string _jobTitle = "";
    public string _jobEmployer ="";
    public int _startYr = 0;
    public int _endYr = 0;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobEmployer}) {_startYr}-{_endYr}");
    }

}