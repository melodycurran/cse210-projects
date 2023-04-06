using System;
using System.Collections.Generic;


public class ViewBalance : BankAcct
{
    public ViewBalance() : base()
    {
    }

    public override double ComputeBalance( double number)
    {
       return _balance += number;
    }
}