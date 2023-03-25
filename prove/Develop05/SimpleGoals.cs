using System;
using System.Collections.Generic;

public class SimpleGoals : Goals
{
    public SimpleGoals() : base()
    {
        _tracker = 1;
    }

    public override string ToString()
    {
        return $"{_goalName},{_goalShortDesc},{_points},{GetIsComplete()}";
    }
}