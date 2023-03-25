using System;
using System.Collections.Generic;


public class ChecklistGoals : Goals
{
    public int _frequency;
    public int _bonus;
    public int _countCompleted;

    public ChecklistGoals() : base()
    {
        _frequency = _goalFrequency;
        _bonus = _bonusPoints;
        _countCompleted = 0;
        _tracker = 3;
    }


    public void BonusQuestions()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _frequency = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus points accomplishing this at that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"{_goalName},{_goalShortDesc},{_points},{_bonus},{_frequency},{_countCompleted}";
    }
}