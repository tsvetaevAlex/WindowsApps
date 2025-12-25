using System.ServiceModel;

namespace Visual.Logger.GUI
{
    [ServiceContract]
    public interface IVisualLogger
    {
        /// <summary>
        /// Отправить строковое сообщение в визуальный логгер
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        [OperationContract]
        void SendMessageToVisualLogger(string message);
    }
}
