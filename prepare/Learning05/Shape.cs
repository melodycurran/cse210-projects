using System;

public class Shape
{
    private string _color;

/////////Constructor//////////
    public Shape()
    {
        _color = "";
    }

/////Getter and Setter//////
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

//////Method//////////
    public virtual double GetArea()
    {
        return -1;
    }
}
