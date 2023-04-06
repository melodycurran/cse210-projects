using System;
using System.Collections.Generic;
using System.IO;


public class WriteBankInfo
{
    private List<BankAcct> _bankAcctInfo;
    private string _fileName;

    public WriteBankInfo()
    {
        _bankAcctInfo = new List<BankAcct>();
        _fileName = "";
    }

    public List<BankAcct> GetBankAcctInfo()
    {
        return _bankAcctInfo;
    }
    public void SetBankAcctInfo(List<BankAcct> bankAcctInfo)
    {
        _bankAcctInfo = bankAcctInfo;
    }
    public string GetFileName()
    {
        return _fileName;
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }

    public void AddToList(BankAcct info)
    {
        _bankAcctInfo.Add(info);
    }

    public void WriteBankAcctInfo(BankAcct info, string email="")
    {
        _fileName = $"{email}.txt";
        using (StreamWriter saveFile = new StreamWriter(_fileName, true))
        {
            
            saveFile.WriteLine(info);
        }
    }
}