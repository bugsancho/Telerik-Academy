using System;
class BankAccountsTest
{
    //simple example of the functionality of the introduced bank account classes.
    static void Main()
    {
        Citizen gosho = new Citizen("Gosho","0123456789");
        DepositAccount account = new DepositAccount(gosho, 5.5f);
        account.Deposit(7500);
        //Ok, i've just found out that the formula I'm using for calculating complex interest is quite wrong, so excuse me for that but I don't have the time to fix it. 
        Console.WriteLine(account.CalculateInterest(1));
    }
}
