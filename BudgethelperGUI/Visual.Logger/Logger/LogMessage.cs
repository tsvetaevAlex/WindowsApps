using System;
using System.Drawing;

namespace Visual.Logger
{
    public class LogMessage
    {
        public DateTime Time { get; }
        public string Text { get; }
        public Color Color { get; }

        public LogMessage(string text, Color color)
        {
            Time = DateTime.Now;
            Text = text;
            Color = color;
        }

        public override string ToString()
        {
            return "[" + Time.ToString("HH:mm:ss") + "] " + Text;
        }
    }
}
