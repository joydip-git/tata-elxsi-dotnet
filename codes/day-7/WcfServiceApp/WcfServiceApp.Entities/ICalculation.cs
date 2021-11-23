using System.ServiceModel;

namespace WcfServiceApp.Entities
{
    [ServiceContract]
    public interface ICalculation
    {
        [OperationContract]
        int AddNumbers(int a, int b);
    }
}
