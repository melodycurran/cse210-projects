using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

/////////////////Constructors///////////////////////
    public Rectangle()
    {
        _length = 0;
        _width = 0;
    }

////////////////////Getters and Setters///////////////////
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }

/////////////////////Methods////////////////////////////
    public override double GetArea()
    {
        return _length * _width;
    }
}