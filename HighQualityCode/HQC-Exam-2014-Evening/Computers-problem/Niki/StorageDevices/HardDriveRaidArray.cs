namespace ComputersSystem.StorageDevices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDriveRaidArray : IHardDriveArray
    {
        private ICollection<IHardDrive> drives;

        public HardDriveRaidArray()
        {
            this.drives = new List<IHardDrive>();
        }

        public int Capacity
        {
            get
            {
                if (!this.drives.Any())
                {
                    return 0;
                }
                else
                {
                    return this.drives.First().Capacity;
                }
            }
        }

        public void AddDrive(IHardDrive drive)
        {
            if (this.drives.Any())
            {
                var typeOfFirstDrive = this.drives.First().GetType();
                var typeOfParameter = drive.GetType();

                if (typeOfFirstDrive == typeOfParameter)
                {
                    this.drives.Add(drive);
                }
                else
                {
                    throw new ArgumentException("Cannot add different type of drive into an array!");
                }
            }
            else
            {
                this.drives.Add(drive);
            }
        }

        public void RemoveDrive(IHardDrive drive)
        {
            if (this.drives.Contains(drive))
            {
                this.drives.Remove(drive);
            }
            else
            {
                throw new ArgumentException("Raid does not containt that drive!");
            }
        }

        public void SaveData(int address, string data)
        {
            if (!this.drives.Any())
            {
                throw new InvalidOperationException("No hard drive in the RAID array!");
            }

            foreach (var drive in this.drives)
            {
                drive.SaveData(address, data);
            }
        }

        public string LoadData(int address)
        {
            if (!this.drives.Any())
            {
                throw new InvalidOperationException("No hard drive in the RAID array!");
            }

            string data = this.drives.First().LoadData(address);
            return data;
        }
    }
}