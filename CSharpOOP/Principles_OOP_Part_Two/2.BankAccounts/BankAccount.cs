using System;
//Class that holds information about a bank account. Implements the IDepositable interface because all bank accounts support depositing(to my knowledge)
// but with future expansion of the project in mind I've separated the method in an interface.
abstract class BankAccount : IDepositable
{
    //fields
    private double balance;
    private float interest;
    private Customer holder;
    //properties
    protected BankAccount(Customer holder, float interest, double balance = 0)
    {
        this.Balance = balance;
        this.InterestRate = interest;
        this.Holder = holder;
    }

    public Customer Holder
    {
        get { return this.holder; }
        protected set { this.holder = value; }
    }

    public float InterestRate
    {
        get { return this.interest; }
        protected set { this.interest = value; }
    }

    public double Balance
    {
        get { return this.balance; }
        protected set { this.balance = value; }
    }
    //methods
    public virtual void Deposit(double amount)
    {
        this.Balance += amount;
    }
    public abstract double CalculateInterest(int numberOfMonths);

    //an internal method that is used for simplyfing the calculation of interest. 
    protected double CalculateComplexInterest(double numberOfMonths, double interestRate)
    {
        return Math.Pow((interestRate / 100), numberOfMonths) * this.Balance;
    }
}
