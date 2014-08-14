namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            protected set
            {
                //if (value <= 2)
                //{
                //    throw new ArgumentException("Cannot have a chair with two or less legs.");
                //}
                this.numberOfLegs = value;
            }
        }
        public override string ToString()
        {
            var info = new StringBuilder(base.ToString());
            info.AppendFormat(", Legs: {0}", this.NumberOfLegs);
            return info.ToString();
        }
    }
}