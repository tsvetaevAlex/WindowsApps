using System.Drawing;
using System.ServiceModel;

namespace Visual.Logger.Server
{
    [ServiceContract]
    public interface IVisualLogger
    {
        /// <summary>
        /// Отправить строковое сообщение в визуальный логгер с указанием цвета
        /// </summary>
        [OperationContract]
        void SendMessage(string message, Color teztColor);

        /// <summary>
        /// Отправить строковое сообщение в визуальный логгер с цветом по умолчанию
        /// </summary>
        [OperationContract]
        void SendMessage(string message);
    }
}
