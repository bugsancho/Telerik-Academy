using System;

class MortgageAccount : BankAccount
{
    public override double CalculateInterest(int numberOfMonths)
    {
        if (this.Holder is Company)
        {
            if (numberOfMonths <= 12)
            {
                return CalculateComplexInterest(numberOfMonths, this.InterestRate / 2);
            }
            else
            {
                return CalculateComplexInterest(12, this.InterestRate / 2) +
                       CalculateComplexInterest(numberOfMonths - 12, this.InterestRate);
            }
        }
        else if (this.Holder is Citizen)
        {
            if (numberOfMonths <= 6)
            {
                return 0;
            }
            else
            {
                return CalculateComplexInterest(numberOfMonths - 6, this.InterestRate);
            }
        }
        else
        {
            throw new NotImplementedException("The following account holder is not supported!");
        }
    }
    public MortgageAccount(Customer holder, float interest, double balance = 0)
        : base(holder, interest, balance)
    {

    }
}