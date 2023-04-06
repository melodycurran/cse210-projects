using System;

public class Withdrawal : BankAcct
{
    private double _withdrawalAmt;

    public Withdrawal() : base()
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


    public double WithdrawalAmt()
    {
        Console.Write("How much do want to withdraw? ");
        
        _withdrawalAmt = -(Convert.ToDouble(Console.ReadLine()));

        return _withdrawalAmt;
    }

    public override string ToString()
    {
        return $"Date: {_date},Time: {_time},{_withdrawalAmt},{_balance},------------------";
    }
}