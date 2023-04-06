using System;

public class Profile : BankAcct
{
    private string _phone;
    
    private string _address;
    
    public Profile() : base()
    {
        
        _phone = "";
        
        _address = "";
    }
    public string GetPhone()
    {
        return _phone;
    }
    public void SetPhone(string phone)
    {
        _phone = phone;
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
        string fName = Console.ReadLine();
        SetFirstName(fName);

        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();
        SetLastName(lName);

        Console.Write("What is your SSN? ");
        string ssn = Console.ReadLine();
        SetSsn(ssn);

        Console.Write("What is your phone number? ");
        _phone = Console.ReadLine();

        Console.Write("What is you email address? ");
        string email = Console.ReadLine();
        SetEmail(email);

        Console.Write("What is your address? ");
        _address = Console.ReadLine();
    }

    public void GetFull()
    {
        string fullName = $"{GetFirstName()}, {GetLastName()}";
        SetFullName(fullName);
    }

    public override string ToString()
    {
        return $"{_fName},{_lName},{_ssn},{_acctNum},{_clientSince},{_email},{_address}";
    }
}