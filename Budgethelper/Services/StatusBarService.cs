using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgethelper.Services
{
    public sealed class StatusBarService : IDisposable
    {
        private readonly RichTextBox _rtb;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly Stopwatch _uptime = new Stopwatch();
        private int _counter;

        public StatusBarService(RichTextBox rtb)
        {
            _rtb = rtb ?? throw new ArgumentNullException(nameof(rtb));
        }

        public void Start()
        {
            if (_uptime.IsRunning)
                return;

            _uptime.Start();
            _ = LoopAsync();
        }

        private async Task LoopAsync()
        {
            try
            {
                while (!_cts.Token.IsCancellationRequested)
                {
                    Render();
                    _counter++;
                    await Task.Delay(500, _cts.Token);
                }
            }
            catch (TaskCanceledException) { }
        }

        private void Render()
        {
            if (_rtb.IsDisposed) return;
            if (_rtb.InvokeRequired)
            {
                _rtb.BeginInvoke(new Action(Render));
                return;
            }

            string uptimeText = $"Session Uptime: {_uptime.Elapsed:dd\\.hh\\:mm\\:ss}";

            _rtb.Clear();
            _rtb.SelectionColor = Color.WhiteSmoke;
            _rtb.AppendText("Status ");

            _rtb.SelectionColor = (_counter % 2 == 0) ? Color.LimeGreen : Color.Black;
            _rtb.AppendText("●");

            _rtb.SelectionColor = Color.WhiteSmoke;
            _rtb.AppendText($"  {uptimeText}");
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
        }
    }
}
