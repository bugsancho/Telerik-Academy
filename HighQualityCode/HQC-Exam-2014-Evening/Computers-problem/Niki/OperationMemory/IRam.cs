namespace ComputersSystem.OperationMemory
{
    public interface IRam
    {
        void SaveValue(int newValue);

        int LoadValue();
    }
}