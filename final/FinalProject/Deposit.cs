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


    public double DepositAmt()
    {
        Console.Write("How much do you want to deposit? ");
        return _depositAmt = Convert.ToDouble(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"Date: {_date},Time: {_time},{_depositAmt},{_balance},------------------";
    }

}