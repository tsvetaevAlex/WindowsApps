using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgethelperGUI
{
    public partial class MainForm : Form
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly Stopwatch _stopwatch = Stopwatch.StartNew();
        private int _heartbeatCounter;
        private const char heatbeatSpotSymbol = '●';
        // private string statusBarText = string.Empty; // удалено, не используется

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ = RunHeartbeatAsync();
        }

        private async Task RunHeartbeatAsync()
        {
            try
            {
                while (!_cts.Token.IsCancellationRequested)
                {
                    var t = _stopwatch.Elapsed;
                    string uptimeStr = $"Uptime: {t:dd\\.hh\\:mm\\:ss}";

                    rtbFooter.BeginInvoke(new Action(() =>
                    {
                        rtbFooter.Clear();
                        rtbFooter.BackColor = Color.Black;


                        // Белый текст
                        rtbFooter.SelectionColor = Color.WhiteSmoke;
                        rtbFooter.AppendText("Heartbeat  ");

                        // Символ ●
                        rtbFooter.SelectionColor = (_heartbeatCounter % 2 == 0) ? Color.LimeGreen : Color.Black;
                        rtbFooter.AppendText("●");

                        // Белый текст с uptime
                        rtbFooter.SelectionColor = Color.WhiteSmoke;
                        rtbFooter.AppendText($"  {uptimeStr}");
                    }));

                    _heartbeatCounter++;
                    await Task.Delay(500, _cts.Token);
                }
            }
            catch (TaskCanceledException)
            {
                // нормальное завершение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _cts.Cancel();
            base.OnFormClosing(e);
        }
    }
}
