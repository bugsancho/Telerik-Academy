class Company : Customer
{
    private int identificationCodeNumber;
    public override string IdentificationCode
    {
        get
        {
            return base.IdentificationCode;
        }
        protected set
        {
            if (value.Length != 9 || int.TryParse(value, out identificationCodeNumber))
            {
                throw new System.ArgumentException("The 'EIK' must be 9 digits long!");
            }
            else
            {
                base.IdentificationCode = value;
            }
        }
    }
    public Company(string name, string identificationCode)
        : base(name, identificationCode)
    {
    }

}