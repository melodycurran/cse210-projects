using System;

public class Circle : Shape
{
    private double _radius;

/////////////////Constructors///////////////////////
    public Circle()
    {
        _radius = 0;
    }


////////////////////Getters and Setters///////////////////
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }


/////////////////////Methods////////////////////////////
    public override double GetArea()
    {
        return Math.Round(Math.Pow(Math.PI * _radius, 2), 2);
    }
}