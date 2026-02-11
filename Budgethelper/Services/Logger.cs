using Budgethelper.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

public partial class Logger : Form
{
    private static Logger _instance;
    private RichTextBox _output;

    private Logger()
    {
        InitializeUI();
    }

    public static void Initialize()
    {
        if (_instance == null)
        {
            _instance = new Logger();
            _instance.Show();
        }
    }

    public static void SendMessage(MessageType type, string message)
    {
        if (_instance == null)
            Initialize();

        _instance.Append(type, message);
    }

    public static void SendMessage(MessageType type, string message, Color color)
    {
        if (_instance == null)
            Initialize();

        _instance.Append(type, message);
    }

    private void Append(MessageType _ьуыыфпуЕype, string message)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => Append(_ьуыыфпуЕype, message)));
            return;
        }

        Color color = GetColor(_ьуыыфпуЕype);

        _output.SelectionStart = _output.TextLength;
        _output.SelectionLength = 0;
        _output.SelectionColor = color;

        _output.AppendText($"[{DateTime.Now:HH:mm:ss}] {_ьуыыфпуЕype}: {message}\n");

        _output.SelectionColor = _output.ForeColor;
        _output.ScrollToCaret();
    }

    private Color GetColor(MessageType type)
    {
        switch (type)
        {
            case MessageType.Info:
                return Color.WhiteSmoke;

            case MessageType.Warn:
                return Color.Orange;

            case MessageType.Debug:
                return Color.Gray;

            case MessageType.DB:
                return Color.MediumBlue;

            case MessageType.UI:
                return Color.LightBlue;

            case MessageType.Account:
                return Color.Lime;

            case MessageType.User:
                return Color.Yellow;
            
            case MessageType.undefined:
                return Color.White;

            default:
                return Color.White;
        }
    }


    private void InitializeUI()
    {
        Text = "Visual Logger";
        Size = new Size(700, 400);
        BackColor = Color.Black;
        FormBorderStyle = FormBorderStyle.SizableToolWindow;

        _output = new RichTextBox
        {
            Dock = DockStyle.Fill,
            BackColor = Color.Black,
            ForeColor = Color.LightGreen,
            BorderStyle = BorderStyle.None,
            Font = new Font("Consolas", 10),
            ReadOnly = true
        };

        Controls.Add(_output);
    }
}
