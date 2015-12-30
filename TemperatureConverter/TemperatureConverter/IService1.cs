using System;
using System.ServiceModel;

namespace TemperatureConverter
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        int c2f(int c);

        [OperationContract]
        int f2c(int f); 
    }
}
