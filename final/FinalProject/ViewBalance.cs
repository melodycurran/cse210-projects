using System;
using System.Collections.Generic;


public class ViewBalance
{
    private List<BankAcct> _bankInfo;

    public ViewBalance()
    {
        _bankInfo = new List<BankAcct>();
    }

    public List<BankAcct> GetBankInfo()
    {
        return _bankInfo;
    }
    public void SetBankInfo(List<BankAcct> bankInfo)
    {
        _bankInfo = bankInfo;
    }


    public void GetBalance()
    {
        // foreach (BankAcct balance in _bankInfo)
        // {
        //     Console.WriteLine(balance);
        // }
    }
}