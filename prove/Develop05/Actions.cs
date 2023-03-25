using System;
using System.Collections.Generic;
using System.IO;

public class Actions
{
    private int _userInput;
    public List<Goals> _listGoals;
    public string _fileName;
    public int _score;
    public string _scoreString;

////////////////Constructors////////////////////////
    public Actions()
    {
        _userInput = 0;
        _listGoals = new List<Goals>();
        _fileName = "";
        _score = 0;
        _scoreString = "";
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
    public void ListGoals(int userSelection = -1)
    {
        foreach (Goals goalInput in _listGoals)
        {
            int index = _listGoals.IndexOf(goalInput);
            bool complete = goalInput.GetIsComplete();

            if (goalInput._tracker == 1)
            {
                if (index == userSelection || complete == true)
                {
                    Console.WriteLine($"[X] {goalInput._goalName} ({goalInput._goalShortDesc})");
                }
                else
                {
                    Console.WriteLine($"[ ] {goalInput._goalName} ({goalInput._goalShortDesc})");
                }
            }
            else if (goalInput._tracker == 2)
            {
                Console.WriteLine($"[ ] {goalInput._goalName} ({goalInput._goalShortDesc})");
            }
            else if (goalInput._tracker == 3)
            {
                if (complete == true)
                {
                    Console.WriteLine($"[X] {goalInput._goalName} ({goalInput._goalShortDesc}) --- completed {goalInput._countCompleted}/{goalInput._goalFrequency}");
                }
                else
                {
                    Console.WriteLine($"[ ] {goalInput._goalName} ({goalInput._goalShortDesc}) --- completed by {goalInput._countCompleted}/{goalInput._goalFrequency}");
                }
            }
        }
    }

//////////////////Save Goals/////////////////////
    public void SaveGoals()
    {   
        Console.Write("What is the name of your file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(_fileName))
        {   
            saveFile.WriteLine(_score);
            foreach (Goals goalInput in _listGoals)
            {   
                // saveFile.WriteLine($"{goalInput._goalName}, {goalInput._goalShortDesc}, {goalInput._points}");
                saveFile.WriteLine(goalInput);
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
            string[] lines = System.IO.File.ReadAllLines(_fileName);

            _scoreString = lines[0];

            lines = lines.Skip(1).ToArray();

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string goalName = parts[0];
                string goalDesc = parts[1];
                string goalPoints = parts[2];
                string bonus = parts[3];
                string frequency = parts[4];
                string completed = parts[5];

                Console.WriteLine($"[ ] {goalName} ({goalDesc})");
            }
        }        
    }

////////////////////////Record Events////////////////////////////////
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");

        foreach (Goals goal in _listGoals)
        {
            Console.WriteLine($"{_listGoals.IndexOf(goal) + 1}. {goal._goalName}");
        }
        
        Console.Write("Which goal did you accomplish? ");
        int userCompletedGoal = int.Parse(Console.ReadLine());

        Goals getGoal = _listGoals[userCompletedGoal - 1];

        if (getGoal._tracker == 1)
        {
            getGoal.SetIsComplete(true);
            _score = getGoal.ComputeScore(_score);
            ListGoals(userCompletedGoal - 1);
        }
        else if (getGoal._tracker == 2)
        {
            _score = getGoal.ComputeScore(_score);
            ListGoals(userCompletedGoal - 1);
        }
        else if (getGoal._tracker == 3)
        {   
            if ( getGoal._countCompleted < getGoal._goalFrequency)
            {
                getGoal._countCompleted++;
                if (getGoal._countCompleted == getGoal._goalFrequency)
                {
                    getGoal.SetIsComplete(true);
                    _score += getGoal._bonusPoints;
                }
            }
            
            _score = getGoal.ComputeScore(_score);
            ListGoals(userCompletedGoal - 1);
        }
    }
}