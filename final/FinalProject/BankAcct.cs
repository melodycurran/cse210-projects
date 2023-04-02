using System;


public class BankAcct
{
    protected double _balance;
    private string _acctNum;
    private string _date;
    private string _time;

    public BankAcct()
    {
        _balance = 0;
        _acctNum = "";
        _date = "";
        _time = "";
    }

    public double GetBalance()
    {
        return _balance;
    }
    public void SetBalance(double balance)
    {
        _balance = balance;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }

    public string CreateBankAcctNum()
    {
        Random getRandom = new Random();
        return _acctNum = "61" + getRandom.Next(100, 999).ToString();
    }

    public string GetCurrentDate()
    {
        DateTime date = DateTime.Today;
        return date.ToString("MM/dd/yyyy");
    }
    
    public string GetCurrentTime()
    {
        DateTime timeNow = DateTime.Now;
        return timeNow.ToString("h:mm:ss tt");

    }

    public virtual double ComputeBalance()
    {
        return -1;
    }
    
}