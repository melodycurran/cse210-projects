using System;

public class Profile : BankAcct
{
    private string _fullName;
    private string _fName;
    private string _lName;
    private string _ssn;
    private string _phone;
    private string _email;
    private string _address;
    
    public Profile() : base()
    {
        _fullName = "";
        _fName = "";
        _lName = "";
        _ssn = "";
        _phone = "";
        _email = "";
        _address = "";
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
    public string GetSsn()
    {
        return _ssn;
    }
    public void SetSsn(string ssn)
    {
        _ssn = ssn;
    }
    public string GetPhone()
    {
        return _phone;
    }
    public void SetPhone(string phone)
    {
        _phone = phone;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }


    public void Questions()
    {
        Console.Write("What is your first name? ");
        _fName = Console.ReadLine();

        Console.Write("What is your last name? ");
        _lName = Console.ReadLine();

        Console.Write("What is your phone number? ");
        _phone = Console.ReadLine();

        Console.Write("What is you email address? ");
        _email = Console.ReadLine();

        Console.Write("What is your address? ");
        _address = Console.ReadLine();
    }

    public string GetFullName()
    {
        return _fullName = $"{_lName}, {_fName}";
    }
}