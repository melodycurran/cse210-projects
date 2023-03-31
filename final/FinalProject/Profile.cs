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

    public string GetFullName()
    {
        return _fullName;
    }
    public void SetFullName(string fullName)
    {
        _fullName = fullName;
    }
    public string GetFirstName()
    {
        return _fName;
    }
    public void SetFirstName(string fName)
    {
        _fName = fName;
    }
}