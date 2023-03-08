using System;


public class Fraction
{
    private int _top;
    private int _bottom;


/// Constructors

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNum)
    {
        _top = wholeNum;
        _bottom = 1;
    }

    public Fraction(int wholeNumTop, int wholeNumBottom)
    {
        _top = wholeNumTop;
        _bottom = wholeNumBottom;
    }


/// Getters and Setters

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


/// Methods
    public void GetFractionString()
    {
        string txt = $"{_top}/{_bottom}";
        return txt;
    }

    public double GetDecimalValue()
    {   
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);
        return top / bottom;
    }

}
