namespace ComputersSystem.Motherboards
{
    using OperationMemory;
    using RenderingDevices;

    public class MotherBoard : IMotherboard
    {
        private IRam ram;
        private IVideoCard videoCard;

        public MotherBoard(IVideoCard videoCard, IRam ram)
        {
            this.VideoCard = videoCard;
            this.Ram = ram;
        }

        public IVideoCard VideoCard
        {
            get { return this.videoCard; }
            private set { this.videoCard = value; }
        }

        public IRam Ram
        {
            get { return this.ram; }
            private set { this.ram = value; }
        }

        public int LoadRamValue()
        {
            int loadedValue = this.Ram.LoadValue();
            return loadedValue;
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.VideoCard.Draw(data);
        }
    }
}
