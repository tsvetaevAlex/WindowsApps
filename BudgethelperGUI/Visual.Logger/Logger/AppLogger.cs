using System.Drawing;

namespace Visual.Logger
{
    public class AppLogger : ILogger
    {
        private readonly VisualLogger _visualLogger;

        public AppLogger(VisualLogger visualLogger)
        {
            _visualLogger = visualLogger;
        }

        public void SendMessage(string message)
        {
            if (_visualLogger == null)
                return;

            _visualLogger.Append(new LogMessage(message, Color.Lime));
        }
    }
}
