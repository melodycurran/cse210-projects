using System;
using System.Collections.Generic;
using System.IO;

public class Actions
{
    private int _userInput;
    public List<Goals> _listGoals;
    public string _fileName;
    Goals goal = new Goals();
    public string _completed;
    public int _score;

////////////////Constructors////////////////////////
    public Actions()
    {
        _userInput = 0;
        _listGoals = new List<Goals>();
        _fileName = "";
        _completed = "X";
        _score = 0;
    }


////////////////Getters and setters/////////////////////////
    public int GetUserInput()
    {
        return _userInput;
    }
    public void SetUserInput(int userInput)
    {
        _userInput = userInput;
    }


///////////////////Methods///////////////////

///////////////////Creating Goals////////////
    public void CreateNewGoals()
    {
        Console.WriteLine("The types of goals are:");
        List<string> listOfGoals = new List<string>(
            new string[] {
                "1. Simple Goal",
                "2. Eternal Goal",
                "3. Checklist Goal"
            }
        );
        foreach (string goal in listOfGoals)
        {
            Console.WriteLine(goal);
        }
        Console.Write("What type of goal would you like to create? ");
        _userInput = int.Parse(Console.ReadLine());

        if (_userInput == 1)
        {
            SimpleGoals simple = new SimpleGoals();
            simple.Questions();
            _listGoals.Add(simple);
        }

        else if (_userInput == 2)
        {
            EternalGoals eternal = new EternalGoals();
            eternal.Questions();
            _listGoals.Add(eternal);
        }

        else if (_userInput == 3)
        {
            ChecklistGoals checklist = new ChecklistGoals();
            checklist.Questions();
            checklist.BonusQuestions();
            _listGoals.Add(checklist);
        }
    }

//////////////////Listing Goals//////////////////////
    public void ListGoals(string completeMark = "")
    {
        foreach (Goals goalInput in _listGoals)
        {
            Console.WriteLine($"[{completeMark}] {goalInput._goalName} ({goalInput._goalShortDesc})");
            // Console.WriteLine(goalInput);
        }
    }

//////////////////Save Goals/////////////////////
    public void SaveGoals()
    {   
        Console.Write("What is the name of your file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(_fileName))
        {   
            foreach (Goals goalInput in _listGoals)
            {   
                saveFile.WriteLine($"{goalInput._goalName}, {goalInput._goalShortDesc}, {goalInput._points}");
                // saveFile.WriteLine(goalInput);
            }
        }
    }

//////////////////////Load Goals///////////////////
    public void LoadGoals()
    {
        Console.Write("What is the name of the file? ");
        string fileNameUserInput = Console.ReadLine();

        if (fileNameUserInput == _fileName)
        {
            _fileName = fileNameUserInput;

            string[] lines = System.IO.File.ReadAllLines(fileNameUserInput);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string goalName = parts[0];
                string goalDesc = parts[1];
                string goalPoints = parts[2];

                Console.WriteLine($"[ ] {goalName} ({goalDesc})");
            }
        }        
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");

        foreach (Goals goal in _listGoals)
        {
            Console.WriteLine($"{_listGoals.IndexOf(goal) + 1}. {goal._goalName}");
        }
        
        Console.Write("Which goal did you accomplish? ");
        int userCompletedGoal = int.Parse(Console.ReadLine());

        = userCompletedGoal;

        if (goal._tracker == 1)
        {
            ListGoals(_completed);
            goal.ComputeScore(_score);
        }

    }

    // public void ComputeScore()
    // {

    // }
}