using System;

class Citizen : Customer
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
            if (value.Length != 10 || !int.TryParse(value, out identificationCodeNumber))
            {
                throw new System.ArgumentException("The 'EGN' must be 10 digits long!");
            }
            base.IdentificationCode = value;
        }
    }
    public Citizen(string name, string identificationCode)
        : base(name, identificationCode)
    {
    }
}