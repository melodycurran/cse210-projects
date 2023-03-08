using System;
using System.Collections.Generic;

public class PromptGenerators
{   

    List<string> _promptContents = new List<string>(
        new string[] {
        "If you had a magic wand, and could wave away your problems, what would your life look like? What\'s stopping you from being the wand?",
        "What are you best at, and what do you love doing most, and how could you spend more time doing both?",
        "If you were unapologetically and truly yourself, day in and day out, and if you fully accepted and loved yourself, what would change for you moving forward?",
        "What makes your heart sing loudest? What makes your heart beat strongest?",
        "What do you believe that no longer serves you? What do you believe that might be holding you back?",
        "What does love mean to you?",
        "How do you define success, and how will you know when you have it?",
        "Where do you see yourself in 3 months, 6 months, and 12 months? Be specific.",
        "What are the ten smallest, most minor, most insignificant things in your life that you are grateful for?",
        "What have been the five best days of your life, and why?",
        "How would your life be different if you stopped living so much in the past and/or worrying so much about the future?",
        "What scares you the most, and why? How can you use that fear to improve or learn or grow?",
        "What would you tell your five-year-old self?",
        "What are three things that you are really looking forward to the most?",
        "Who do you need to forgive, and why, and what\'s stopping you from doing it today?",
        "If you could change one thing about yourself, what would it be and what\'s stopping you from taking action?",
        "How would your life change if you were your own biggest fan and truly believed in yourself?",
        "What is the best advice you have ever been given?",
        "How do you deal with helplessness, with letting go, with release and surrender of expectations?",
        "What do you love most about yourself?",
        "Who do you admire most in this world, and why?",
        "What are five things you absolutely, positively, totally want to do before you die, and how can you do one of them THIS YEAR?",
        "Who do you care about most in the world, and what could you do today to make sure they know it?",
        "What would you truly lose, deep down, if you lost what you are most scared of losing?",
        "What are five things that you love most in the world?",
        "What about your life makes you the most proud?",
        "When did you hurt most, and how has it helped you or taught you or improved you?",
        "What does it mean to be good enough, and how do you know that you are?",
        "What did you really love doing as a kid but don\'t really do anymore? What is stopping you from doing it now, and what would happen if you did?",
        "If you could, what is the one thing you would change about your past?",
        "What makes you feel happy to be alive, and how can you make more of that every day?",
        "What truth have you been refusing to admit to yourself and how could you face it?",
        "What three things could you give up that would give you more time, energy, and peace?",
        "What does your ideal day look like? Be specific.",
        "What does heroic mean to you, and who are your biggest heroes?",
        "What advice would you give yourself five years ago?",
        "What do you love most about your life?",
        "If you found out that you were going to die tomorrow, what would be your three biggest regrets?",
        "What are you the most scared of losing, and what would you truly lose if you lost it?",
        "What one event in your life has changed you the most?",
        "If you could be president for one day, what would you do, and why?",
        "Assuming your life is a story and you are the author, what does your happy ending look like?",
        "When are you at your best, and how do you get back there when you feel unbalanced or unwell?",
        "How can you improve the way you treat yourself and talk to yourself?",
        "When was the last time you cried, and what did it teach you?",
        "What is your personal mantra for this year? What one word best describes your best life moving forward?",
        "If you could invite five people, living or dead, to dinner at your house one night, who would you choose, and what would you cook them?",
        "What are the five most important things in your life right now and how are you prioritizing them (or not)?",
        "What makes you the most angry, the most frustrated, the most annoyed, and why?",
        "What is something you have never done, but always wanted to do, and what is so important about this for you?"
            }
        );

        public string GeneratePrompt()
        {
            Random randomNum = new Random();
            int random = randomNum.Next(0,50);

            string stringPrompt = _promptContents[random];
            
            return stringPrompt;
        }
    }