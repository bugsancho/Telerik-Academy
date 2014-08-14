namespace ComputersSystem.StorageDevices
{
    using System;
    using System.Collections.Generic;

    public class HardDrive : IHardDrive
    {
        private int capacity;
        private IDictionary<int, string> data;

        public HardDrive(int capacity)
        {
            this.Capacity = capacity;
            this.data = new Dictionary<int, string>();
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hard drive capacity cannot be negative!");
                }

                this.capacity = value;
            }
        }

        public void SaveData(int address, string data)
        {
            this.data[address] = data;
        }

        public string LoadData(int address)
        {
            if (!this.data.ContainsKey(address))
            {
                throw new ArgumentException("Invalid data address!");
            }

            return this.data[address];
        }
    }
}