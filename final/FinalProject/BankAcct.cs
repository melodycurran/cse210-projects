using System;


public class BankAcct
{
    protected string _fName;
    protected string _lName;
    private string _fullName;
    protected string _ssn;
    protected double _balance;
    protected string _acctNum;
    protected string _date;
    protected string _time;
    protected string _clientSince;
    protected string _email;

    public BankAcct()
    {
        _fName = "";
        _lName = "";
        _fullName = "";
        _ssn = "";
        _balance = 0;
        _acctNum = "";
        _date = "";
        _time = "";
        _clientSince = "";
        _email = "";
        
    }

    public string GetFirstName()
    {
        return _fName;
    }
    public void SetFirstName(string fName)
    {
        _fName = fName;
    }
    public string GetLastName()
    {
        return _lName;
    }
    public void SetLastName(string lastName)
    {
        _lName = lastName;
    }

    public string GetFullName()
    {
        return _fullName;
    }
    public void SetFullName(string fullName)
    {
        _fullName = fullName;
    }
    public string GetSsn()
    {
        return _ssn;
    }
    public void SetSsn(string ssn)
    {
        _ssn = ssn;
    }
    public double GetBalance()
    {
        return _balance;
    }
    public void SetBalance(double balance)
    {
        _balance = balance;
    }
    public string GetAcctNum()
    {
        return _acctNum;
    }
    public void SetAcctNum(string acctNum)
    {
        _acctNum = acctNum;
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
    public string GetClientSinceDate()
    {
        return _clientSince;
    }
    public void SetClientSinceDate(string clientSince)
    {
        _clientSince = clientSince;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }

    

    public string CreateBankAcctNum()
    {
        Random getRandom = new Random();
        return _acctNum = "61" + getRandom.Next(100, 999).ToString();
    }

    public void ClientSince()
    {
       string signUpDAte = GetCurrentDate();
       SetClientSinceDate(signUpDAte);

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

    public virtual double ComputeBalance(double number)
    {
        return -1;
    }

    public override string ToString()
    {
        return $"{_fName},{_lName},{_ssn},{_balance},{_acctNum},{_clientSince},{_email}";
    }
    
}