using System;

abstract class Customer
{
    private string name;
    private string identificationCode;

    public Customer(string name, string identificationCode)
    {
        this.IdentificationCode = identificationCode;
        this.Name = name;
    }

    public virtual string IdentificationCode
    {
        get { return this.identificationCode; }
        protected set { this.identificationCode = value; }
    }
    
    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }
}
