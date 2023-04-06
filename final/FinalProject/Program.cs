using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        string divider = "===============================================================================";
        WriteBankInfo writeBankInfo = new WriteBankInfo();
        RetrieveBankInfo retrieve = new RetrieveBankInfo();
        ViewBalance viewBalance = new ViewBalance();
        List<string> acctDetails = retrieve.GetNewList();
        List<string> transactions = retrieve.GetNewTransactionList();
        
        BankAcct bank = new BankAcct();
        string emailAddress = "";
        
        Console.WriteLine(divider);
        Console.WriteLine("WELCOME TO MELODY'S BANK");
        Console.WriteLine("---- Current interest rate is at 4% annually. No minimun deposit required! ----");
        Console.WriteLine(divider);

        emailAddress = retrieve.GetEmail();
        string file = $"{emailAddress}.txt";

        if (File.Exists(file))
        {
            retrieve.ReadFile(emailAddress);
            Console.WriteLine($"Welcome back, {acctDetails[0]}!");
        }
        else
        {
            Console.WriteLine("There's no account associated with this email. Please go ahead and sign up.");
            Console.WriteLine("If you want to sign in again, enter 6 to quit. Re-run the program and re-enter email.");
        }

         while (userInput != 6)
        {  
            Console.WriteLine(divider);
            List<string> menuList = new List<string>(
                new string [] {
                    "1. Create Account",
                    "2. Deposit",
                    "3. Withdrawal",
                    "4. View Balance",
                    "5. View Transaction History"
                }
            );

            foreach (string menu in menuList)
            {
                Console.WriteLine(menu);
            }
            
            Console.Write("Enter the number of the corresponding choice: ");
            userInput = int.Parse(Console.ReadLine());   

            Console.WriteLine(divider);

            if (userInput == 1)
            {
                Profile person = new Profile();
                person.Questions();
                person.GetFull();
                person.CreateBankAcctNum();
                person.ClientSince();
                person.SetEmail(emailAddress);

                writeBankInfo.WriteBankAcctInfo(person, emailAddress);
                
                Console.WriteLine(divider);
            }

            else if (userInput == 2)
            {
                Deposit deposit =  new Deposit();
                string date = deposit.GetCurrentDate();
                deposit.SetDate(date);
                string time = deposit.GetCurrentTime();
                deposit.SetTime(time);

                double depositAmt = deposit.DepositAmt();

                retrieve.ReadFile(emailAddress);
                int listLength = transactions.Count();
                if (listLength < 5)
                {
                    viewBalance.SetBalance(0);
                }
                else
                {
                    viewBalance.SetBalance(Convert.ToDouble(transactions[listLength-2]));
                }

                deposit.SetBalance(viewBalance.ComputeBalance(depositAmt));
                writeBankInfo.WriteBankAcctInfo(deposit, emailAddress);

                Console.WriteLine($"You deposited {depositAmt} today.");
            }
            else if (userInput == 3)
            {
                Withdrawal withdraw = new Withdrawal();
                string date = withdraw.GetCurrentDate();
                withdraw.SetDate(date);
                string time = withdraw.GetCurrentTime();
                withdraw.SetTime(time);

                double withdrawAmt = withdraw.WithdrawalAmt();

                retrieve.ReadFile(emailAddress);
                int listLength = transactions.Count();
                if (listLength < 5)
                {
                    viewBalance.SetBalance(0);
                }
                else
                {
                    viewBalance.SetBalance(Convert.ToDouble(transactions[listLength-2]));
                    if (-(withdrawAmt) > viewBalance.GetBalance())
                    {
                        Console.WriteLine("You don't have enough balance to withdraw.");
                    }
                    else
                    {
                        withdraw.SetBalance(viewBalance.ComputeBalance(withdrawAmt));
                        writeBankInfo.WriteBankAcctInfo(withdraw, emailAddress);

                        Console.WriteLine($"You withdrew {withdrawAmt} today.");
                    }
                }

                
            }
            else if (userInput == 4)
            {
                retrieve.ReadFile(emailAddress);
                int listLength = transactions.Count();

                if (listLength < 5)
                {
                    Console.WriteLine("Your total balance is 0");
                }
                else
                {
                    Console.WriteLine($"Your total balace is {transactions[listLength-2]}"); 
                }          
            }
            else if (userInput == 5)
            {
                retrieve.ReadFile(emailAddress);

                Console.WriteLine($"Name: {acctDetails[0]} {acctDetails[1]}");
                Console.WriteLine($"SSN: {acctDetails[2]}");
                Console.WriteLine($"Account Number: {acctDetails[3]}");
                Console.WriteLine($"Client since: {acctDetails[4]}");
                Console.WriteLine($"Email: {acctDetails[5]}");
                Console.WriteLine($"Address: {acctDetails[6]}");

                Console.WriteLine("------------------");
  
                foreach (string transaction in transactions)
                {
                    Console.WriteLine(transaction);  
                }

                
            }
        }
    }
}