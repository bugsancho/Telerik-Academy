namespace ComputersSystem.OperationMemory
{
    public class Ram : IRam
    {
        private int value;

        internal Ram(int capacity)
        {
            this.Capacity = capacity;
        }

        private int Capacity { get; set; }

        // TODO add validation
        public void SaveValue(int newValue)
        {
            this.value = newValue;
        }

        public int LoadValue()
        {
            return this.value;
        }
    }
}