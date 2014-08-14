namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty.");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be less than 3 characters long.");
                }


                this.model = value;
            }
        }
        public string Material
        {
            get { return this.material; }
            protected set { this.material = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero.");
                }

                this.price = value;
            }
        }
        public decimal Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to zero.");
                }
                this.height = value;
            }
        }
        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
            return info.ToString();
        }


    }
}
