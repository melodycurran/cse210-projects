using System;

public class Withdrawal : BankAcct
{
    private double _withdrawalAmt;

    public Withdrawal()
    {
        _withdrawalAmt = 0;
    }

    public double GetWithdrawalAmt()
    {
        return _withdrawalAmt;
    }
    public void SetWithdrawalAmt(double withdraw)
    {
        _withdrawalAmt = withdraw;
    }


    public override double ComputeBalance()
    {
        Console.Write("How much do want to withdraw? ");
        _withdrawalAmt = Convert.ToDouble(Console.ReadLine());
        return  _balance += _withdrawalAmt;
    }
}