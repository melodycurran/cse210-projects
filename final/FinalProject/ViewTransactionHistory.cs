using System;
using System.Collections.Generic;


public class ViewTransactionHistory
{
    private List<BankAcct> _histories;

    public ViewTransactionHistory()
    {
        _histories = new List<BankAcct>();
    }

    public List<BankAcct> GetHistory()
    {
        return _histories;
    }
    public void SetHistory(List<BankAcct> histories)
    {
        _histories = histories;
    }


    public void GetTransationHistory()
    {
        // foreach (BankAcct history in _histories)
        // {
        //     Console.WriteLine(history);
        // }
    }
}