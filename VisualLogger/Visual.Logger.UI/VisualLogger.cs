using System;
using System.Drawing;
using System.Windows.Forms;
using WebAutomation.Enum;

namespace WebAutomation.Logger.Visual
{
    public sealed partial class VisualLogger : Form
    {
        //protected readonly SynchronizationContext synchronizationContext;
        //private ServiceHost host;
        private static string visualLoggerNameVersionTitleString = " - Visual Logger 1.0.2";
        //public VisualLogger(ServiceHost host)
        public VisualLogger()
        {
            InitializeComponent();

            //synchronizationContext = SynchronizationContext.Current;

            SuspendLayout();
            // 
            // loggerTextBox
            // 
            loggerTextBox = new RichTextBox()
            {
                BorderStyle = BorderStyle.None,
                Location = new Point(5, 5),
                Multiline = true,
                Name = "loggerTextBox",
                Size = new Size(800, 200),
                TabIndex = 0,
                Visible = true,
                Enabled = true,
                //BackColor = System.Drawing.SystemColors.InactiveCaptionText
                BackColor = Color.Black,
        };

            // 
            // LoggerFrame
            // 
            //this.Icon = Icon.
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(750, 200);
            Controls.Add(loggerTextBox);
            Enabled = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(10, 10);
            Name = "LoggerFrame";
            StartPosition = FormStartPosition.Manual;
            Text = @"Wait for Test Case Initialization" + visualLoggerNameVersionTitleString;
            ResumeLayout(false);
            PerformLayout();

            //IObservable<string> langObsp = Observable.FromEventPattern<string>(
            //    logHandler => Log.TextOutputEvent += logHandler,
            //    logHandler => Log.TextOutputEvent -= logHandler
            //    ).Select(l => l.EventArgs);
            //LogDisposable = langObsp.Subscribe(WriteText);


            //Log.TextOutputEvent += Log_TextOutputEvent;
        }

        public void SetWindowTitle(string windowTitle)
        {
            Text = windowTitle + visualLoggerNameVersionTitleString;
        }

        //private void Log_TextOutputEvent(object sender, string e)
        //{
        //    //throw new NotImplementedException();
        //    WriteText(e);
        //}

        public void WriteText(LogLevel logLevel, string msg)
        {
            //this.Invoke((MethodInvoker)(() => loggerTextBox.AppendText(msg + "\r\n")));

            Color color;
            switch (logLevel)
            {
                case LogLevel.Warning:
                    color = Color.Pink;
                    break;
                case LogLevel.Error: 
                //case LogLevel.Fatal:
                //    color = Color.Red;
                //    break;
                //case LogLevel.TestCase:
                //    color = Color.DeepSkyBlue;
                //    break;
                //case LogLevel.Screenshot:
                //    color = Color.Tomato;
                    break;
                case LogLevel.Performance:
                    color = Color.Orange;
                    break;
                case LogLevel.Info:
                    color = Color.Chartreuse;
                    break;
                case LogLevel.Debug:
                    color = Color.GhostWhite;
                    break;
                default:
                    color = ForeColor;
                    break;
            }

            if (loggerTextBox.InvokeRequired)
            {
                loggerTextBox.Invoke((MethodInvoker)delegate
                {

                    loggerTextBox.SelectionStart = loggerTextBox.TextLength;
                    loggerTextBox.SelectionLength = 0;

                    loggerTextBox.SelectionColor = color;
                    loggerTextBox.AppendText(logLevel.ToString() + ": " + msg + "\r\n");
                    loggerTextBox.SelectionColor = loggerTextBox.ForeColor;

                    loggerTextBox.AppendText(msg + "\r\n");
                    loggerTextBox.ScrollToCaret();
                });
           }
            else
            {
                loggerTextBox.SelectionStart = loggerTextBox.TextLength;
                loggerTextBox.SelectionLength = 0;

                loggerTextBox.SelectionColor = color;
                loggerTextBox.AppendText(logLevel.ToString() + ": " + msg + "\r\n");
                loggerTextBox.SelectionColor = loggerTextBox.ForeColor;
                //loggerTextBox.AppendText(msg + "\r\n");
                loggerTextBox.ScrollToCaret();
            }

            //loggerTextox.


            //synchronizationContext.Send(new SendOrPostCallback(o =>
            //{
            //    loggerTextBox.AppendText((string)o + "\r\n");
            //}), msg);


            //if (loggerTextBox.InvokeRequired)
            //{
            //    loggerTextBox.Invoke(new MethodInvoker(() => loggerTextBox.AppendText(msg + "\r\n")));
            //}
            //else
            //{
            //    loggerTextBox.AppendText(msg + "\r\n");
            //    //loggerTextBox.Refresh();
            //}

            //Invoke(new MethodInvoker(() =>
            //{
            //    loggerTextBox.AppendText(msg + "\r\n");
            //    loggerTextBox.Refresh();
            //}));

            //Log.IsVisualBusy = false;
        }

        private void VisualLogger_Load(object sender, EventArgs e)
        {
            Visible = true;
            //LoggerService logService = new LoggerService();
            //LoggerService.StartVisualLogger();
            //LoggerService.Main();
        }

        public void StopVisualLogger()
        {
            Close();
        }
    }
}
