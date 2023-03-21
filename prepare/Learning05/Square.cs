using System;


public class Square : Shape
{

////////Variables///////////
    private double _side;

/////////Constructor//////////////
    public Square()
    {
        _side = 0;
    }

/////////Getters and Setters////////////////
    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

///////////////Method/////////////////
    public override double GetArea()
    {
        return _side * _side;
    }
}