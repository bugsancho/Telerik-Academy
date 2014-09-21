namespace SubstringCountService
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IGetSubstringCountService
    {
        [OperationContract]
        int GetSubstringCount(string message, string substring);
    }
}