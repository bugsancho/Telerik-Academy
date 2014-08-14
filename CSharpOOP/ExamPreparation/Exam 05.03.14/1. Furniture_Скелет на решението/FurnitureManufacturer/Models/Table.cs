namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Table : Furniture, ITable
    {
        private decimal width;
        private decimal length;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get { return this.length; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The length of a table cannot be less or equal to zero");
                }
                this.length = value;
            }
        }

        public decimal Width
        {
            get { return this.width; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of a table cannot be less or equal to zero");
                }
                this.width = value;
            }
        }

        public decimal Area
        {
            get { return this.Width * this.Length; }
        }

        public override string ToString()
        {
            var info = new StringBuilder(base.ToString());
            info.AppendFormat(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
            return info.ToString();
        }
    }
}