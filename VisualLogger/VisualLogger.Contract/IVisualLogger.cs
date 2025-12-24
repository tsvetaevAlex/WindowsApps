using System.ServiceModel;
using Visual.Logger.Contract;

namespace Visual.Logger.Contract
{
    [ServiceContract] // Говорим WCF что это интерфейс для запросов сервису
    public interface IVisualLogger
    {
        [OperationContract] // Делегируемый метод.
        void SendMessageToVisualLogger(LogLevel logLevel, string logMessage);

        [OperationContract] // Делегируемый метод.
        void StopLogger();

        [OperationContract] // Делегируемый метод.
        void SetWindowTitle(string windowTitle);
    }
}
