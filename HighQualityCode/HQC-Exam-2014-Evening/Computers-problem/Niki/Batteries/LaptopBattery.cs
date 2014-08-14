namespace ComputersSystem.Batteries
{
    using System;

    public class LaptopBattery : IBattery
    {
        private int powerLeftPercentage;

        public LaptopBattery()
        {
            this.PowerLeftPercentage = 50;
        }

        public int PowerLeftPercentage
        {
            get
            {
                return this.powerLeftPercentage;
            }

            private set
            {
                this.powerLeftPercentage = value;
            }
        }

        public void Charge(int percentage)
        {
            if (percentage + this.PowerLeftPercentage < 0)
            {
                this.powerLeftPercentage = 0;
            }
            else if (percentage + this.PowerLeftPercentage > 100)
            {
                this.powerLeftPercentage = 100;
            }
            else
            {
                this.PowerLeftPercentage += percentage;
            }
        }
    }
}