using System;

class LoanAccount : BankAccount
{
    public override double CalculateInterest(int numberOfMonths)
    {
        if (this.Holder is Citizen)
        {
            if (numberOfMonths >= 3)
            {
                return CalculateComplexInterest(numberOfMonths, this.InterestRate);
            }
            else
            {
                return 0;
            }
        }
        else if (this.Holder is Company)
        {
            if (numberOfMonths >= 2)
            {
                return CalculateComplexInterest(numberOfMonths, this.InterestRate);
            }
            else
            {
                return 0;
            }
        }
        else
        {
            throw new NotImplementedException("The following account holder is not supported!");
        }
    }
    public LoanAccount(Customer holder, float interest, double balance = 0)
        : base(holder, interest, balance)
    {

    }
}