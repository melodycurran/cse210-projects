using System;


public class Deposit : BankAcct
{
    private double _depositAmt;

    public Deposit() : base()
    {
        _depositAmt = 0;
    }

    public double GetDepositAmt()
    {
        return _depositAmt;
    }
    public void SetDepositAmt(double deposit)
    {
        _depositAmt = deposit;
    }


    public override double ComputeBalance()
    {
        Console.Write("How much do you want to deposit? ");
        _depositAmt = Convert.ToDouble(Console.ReadLine());
        return _balance += _depositAmt;
    }

}