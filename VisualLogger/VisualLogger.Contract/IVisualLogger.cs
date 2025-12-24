using System.ServiceModel;

namespace Visual.Logger.Contract
{
    [ServiceContract]
    public interface IVisualLogger
    {
        [OperationContract]
        void SendMessageToVisualLogger(LogLevel logLevel, string logMessage);

        [OperationContract]
        void SetWindowTitle(string windowTitle);

        [OperationContract]
        void StopLogger();
    }
}
