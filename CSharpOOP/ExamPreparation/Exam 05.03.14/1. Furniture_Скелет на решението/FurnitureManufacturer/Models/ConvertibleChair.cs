namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10m;        
        private readonly decimal initialHeight;
        private bool isConverted;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.initialHeight = height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            protected set { this.isConverted = value; }
        }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.IsConverted = false;
                this.Height = initialHeight;
            }
            else
            {
                this.IsConverted = true;
                this.Height = ConvertedHeight;
            }
        }

         public override string ToString()
        {
            var info = new StringBuilder(base.ToString());
            info.AppendFormat(", State: {0}", this.IsConverted ? "Converted" : "Normal");
            return info.ToString();
        }
    }
}