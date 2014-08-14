namespace ComputersSystem.Computers
{
    using System;
    using Batteries;
    using Motherboards;
    using ProccessingUnit;
    using StorageDevices;

    public class Laptop : Computer, ILaptop
    {
        private const string BatterChargeStatusMessageTemplate = "Battery status: {0}%";
        private IBattery battery;
        
        public Laptop(ICpu cpu, IMotherboard motherboard, IHardDrive drive, IBattery battery) : base(cpu, motherboard, drive)
        {
            this.Battery = battery;
        }

        public IBattery Battery
        {
            get
            {
                return this.battery;
            }
            
            private set
            {
                this.battery = value;
            }
        }

        public void Charge(int percentage)
        {
            this.Battery.Charge(percentage);
            string batteryStatusMessage = string.Format(Laptop.BatterChargeStatusMessageTemplate, this.battery.PowerLeftPercentage);
            this.Motherboard.DrawOnVideoCard(batteryStatusMessage);
        }
    }
}