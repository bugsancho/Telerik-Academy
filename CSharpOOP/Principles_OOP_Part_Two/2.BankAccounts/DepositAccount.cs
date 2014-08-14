using System;

class DepositAccount : BankAccount, IWithdrawable
{
    public DepositAccount(Customer holder, float interest, double balance = 0)
        : base(holder, interest, balance)
    {

    }

    public void Withdraw(double amount)
    {
        if (this.Balance > amount)
        {
            this.Balance -= amount;
        }
        else
        {
            throw new OperationCanceledException("Insuficient funds!");
        }
    }

    public override double CalculateInterest(int numberOfMonths)
    {
        if (this.Balance >= 1000 || this.Balance <= 0)
        {
            return CalculateComplexInterest(numberOfMonths, this.InterestRate);
        }
        else
        {
            return 0;
        }
    }
}