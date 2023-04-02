using System;


public class WriteBankInfo
{
    private List<BankAcct> _bankAcctInfo;

    public WriteBankInfo()
    {
        _bankAcctInfo = new List<BankAcct>();
    }

    public List<BankAcct> GetBankAcctInfo()
    {
        return _bankAcctInfo;
    }
    public void SetBankAcctInfo(List<BankAcct> bankAcctInfo)
    {
        _bankAcctInfo = bankAcctInfo;
    }

    public void WriteBankAcctInfo()
    {
        
    }
}