using System;
using System.Collections.Generic;

public class SimpleGoals : Goals
{
    public bool _IsDone;

    public SimpleGoals() : base()
    {
        _tracker = 1;
        _IsDone = false;
    }

    public override string ToString()
    {
        return $"{_goalName},{_goalShortDesc},{_points},{_IsDone}";
    }
}