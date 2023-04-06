using System;
using System.Collections.Generic;
using System.IO;


public class RetrieveBankInfo
{
    private string _fileName;
    private List<string> _reconstructList;
    private List<string> _reconstructTransactionList;

    public RetrieveBankInfo()
    {
        _fileName = "";
        _reconstructList = new List<string>();
        _reconstructTransactionList = new List<string>();
    }

    public string GetFileName()
    {
        return _fileName;
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public List<string> GetNewList()
    {
        return _reconstructList;
    }
    public void SetNewList(List<string> newList)
    {
        _reconstructList = newList;
    }
    public List<string> GetNewTransactionList()
    {
        return _reconstructTransactionList;
    }
    public void SetNewTransactionList(List<string> transactionList)
    {
        _reconstructTransactionList = transactionList;
    }



    public void ReadFile(string email)
    {
        _fileName = $"{email}.txt";

        string firstLine = System.IO.File.ReadAllLines(_fileName).Skip(0).Take(1).First();

        
            string[] parts = firstLine.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
            string ssn = parts[2];
            string acctNum = parts[3];
            string signUpDate = parts[4];
            string emailAddress = parts[5];
            string address = parts[6];

            _reconstructList.Add(firstName);
            _reconstructList.Add(lastName);
            _reconstructList.Add(ssn);
            _reconstructList.Add(acctNum);
            _reconstructList.Add(signUpDate);
            _reconstructList.Add(email);
            _reconstructList.Add(address);
        
       
       string[] lines = System.IO.File.ReadAllLines(_fileName);

       lines = lines.Skip(1).ToArray();

       foreach (string line in lines)
        {
            string[] parts1 = line.Split(",");

            string transactionDate = parts1[0];
            string transactionTime = parts1[1];
            string transactionAmt = parts1[2];
            string balance = parts1[3];
            string endLine = parts1[4];

            _reconstructTransactionList.Add(transactionDate);
            _reconstructTransactionList.Add(transactionTime);
            _reconstructTransactionList.Add(transactionAmt);
            _reconstructTransactionList.Add(balance);
            _reconstructTransactionList.Add(endLine);

        }
    }

    public string GetEmail()
    {
        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        return email;
    }
}   