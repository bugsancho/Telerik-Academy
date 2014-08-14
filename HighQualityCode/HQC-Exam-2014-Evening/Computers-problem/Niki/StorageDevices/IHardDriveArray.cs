namespace ComputersSystem.StorageDevices
{
    public interface IHardDriveArray : IHardDrive
    {
        void AddDrive(IHardDrive drive);

        void RemoveDrive(IHardDrive drive);
    }
}