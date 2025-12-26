using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.Logger.GUI
{
    public sealed partial class VisualLoggerForm : Form
    {
        private Socket _listener;

        public VisualLoggerForm()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            loggerTextBox.BackColor = Color.Black;
            loggerTextBox.ForeColor = Color.LightGreen;
            loggerTextBox.Font = new Font("Consolas", 10);
            loggerTextBox.BorderStyle = BorderStyle.None;
            StartListening();
        }

        private void AppendLog(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendLog), text);
                return;
            }

            loggerTextBox.AppendText(text + Environment.NewLine);
        }

        private async void StartListening()
        {
            _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            _listener.Bind(new IPEndPoint(IPAddress.Any, 4000));
            _listener.Listen(100);

            AppendLog("Server started on port 4000...");

            while (true)
            {
                var client = await Task.Factory.FromAsync(
                    _listener.BeginAccept,
                    _listener.EndAccept,
                    null);

                AppendLog("Client connected");

                HandleClient(client);
            }
        }

        private async void HandleClient(Socket client)
        {
            var buffer = new byte[4096];

            while (true)
            {
                var args = new SocketAsyncEventArgs();
                args.SetBuffer(buffer, 0, buffer.Length);

                var tcs = new TaskCompletionSource<int>();

                args.Completed += (s, e) =>
                {
                    if (e.SocketError == SocketError.Success)
                        tcs.TrySetResult(e.BytesTransferred);
                    else
                        tcs.TrySetException(new SocketException((int)e.SocketError));
                };

                if (!client.ReceiveAsync(args))
                {
                    if (args.SocketError == SocketError.Success)
                        tcs.TrySetResult(args.BytesTransferred);
                    else
                        tcs.TrySetException(new SocketException((int)args.SocketError));
                }

                int bytes = await tcs.Task;

                if (bytes == 0)
                {
                    AppendLog("Client disconnected");
                    client.Close();
                    break;
                }

                string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                AppendLog(msg);
            }
        }
    }
}
