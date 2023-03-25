using System;
using System.Collections.Generic;


public class ChecklistGoals : Goals
{
    public ChecklistGoals() : base()
    {
        _tracker = 3;
    }


    public void BonusQuestions()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalFrequency = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus points accomplishing this at that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"{_goalName},{_goalShortDesc},{_points},{_bonusPoints},{_goalFrequency},{_countCompleted}";
    }
}