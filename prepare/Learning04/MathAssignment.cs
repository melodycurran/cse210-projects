using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment()
    {
        _textbookSection = "";
        _problems = "";
    }

    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetTextbookName()
    {
        return _textbookSection;
    }
    public void SetTextbookName(string textBook)
    {
        _textbookSection = textBook;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    
    public string GetHomeWorkList()
    {
        return $"{_textbookSection} {_problems}";
    }

}