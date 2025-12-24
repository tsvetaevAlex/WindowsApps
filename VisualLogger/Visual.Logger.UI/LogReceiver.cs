using System.ServiceModel;
using Visual.Logger.Contract;
using Visual.Logger.UI;

namespace Visual.Logger.Service
{
    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.Single
    )]
    public class LogReceiver : IVisualLogger
    {
        private readonly VisualLogger visualLogger;
        public static object Lock = new object();

        public LogReceiver(VisualLogger form)
        {
            visualLogger = form;
        }

        public void SendMessageToVisualLogger(LogLevel logLevel, string logMessage)
        {
            visualLogger.WriteText(logLevel, logMessage);
        }

        public void SetWindowTitle(string windowTitle)
        {
            visualLogger.SetWindowTitle(windowTitle);
        }

        public void StopLogger()
        {
            visualLogger.StopVisualLogger();
        }
    }
}
