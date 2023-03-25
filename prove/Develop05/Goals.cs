using System;
using System.Collections.Generic;

public class Goals
{
////////////////Variables///////////////////
    private bool _isComplete;
    public string _goalName;
    public string _goalShortDesc;
    public int _points;
    public int _goalFrequency;
    public int _bonusPoints;
    public int _tracker;

////////////////Constructors///////////////////
    public Goals()
    {
        _isComplete = false;
        _goalName = "";
        _goalShortDesc = "";
        _points = 0;
        _goalFrequency = 0;
        _bonusPoints = 0;
        _tracker = 0;
    }
    
////////////Getters and setters//////////////////
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

//////////////Methods//////////////////////////////
    public void Questions()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        
        Console.Write("What is the short description of it? ");
        _goalShortDesc = Console.ReadLine();

        Console.Write("What is the amount of point associated with it? ");
        _points = int.Parse(Console.ReadLine());
    }

    public void ComputeScore(int score)
    {
        score += _points;
    }
}