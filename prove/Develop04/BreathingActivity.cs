using System;
using System.Collections.Generic;


public class BreathingActivity : Activity
{
    public string _actName;
    public string _descName;

    public BreathingActivity() : base()
    {
        _actName = "Breathing Activity";
        _descName = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreatheIn()
    {
        Console.Write("Breathe in...");
    }

    public void BreatheOut()
    {
        Console.Write("Now breathe out...");
    }
}