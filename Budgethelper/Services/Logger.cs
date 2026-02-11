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

        _instance.Append_ByMessageType(type, message);
    }
    public static void SendMessage(string message,Color color)
    {
        if (_instance == null)
            Initialize();

        _instance.Append_ColorMessage(message, color);
    }
    private void Append_ByMessageType(MessageType MessageType, string message)
    {
        if (InvokeRequired)
        {
            Color textColor = GetColor(MessageType);
            Invoke(new Action(() => Append_ColorMessage(message,textColor)));
            return;
        }

        Color color = GetColor(MessageType);

        _output.SelectionStart = _output.TextLength;
        _output.SelectionLength = 0;
        _output.SelectionColor = color;

        _output.AppendText($"[{DateTime.Now:HH:mm:ss}] {MessageType}: {message}\n");

        _output.SelectionColor = _output.ForeColor;
        _output.ScrollToCaret();
    }

    private void Append_ColorMessage(string message, Color color)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => Append_ColorMessage(message, color)));
            return;
        }


        _output.SelectionStart = _output.TextLength;
        _output.SelectionLength = 0;
        _output.SelectionColor = color;

        _output.AppendText($"[{DateTime.Now:HH:mm:ss}] : {message}\n");

        _output.SelectionColor = _output.ForeColor;
        _output.ScrollToCaret();
    }

    #region colorring with own prompt message for each type of message
    private Color GetColor(MessageType _MessageType)
    {
        string prompt = string.Empty;
        switch (_MessageType)
        {
            case MessageType.Info:
                {
                    prompt = "информационное Сообщение:";
                    SendMessage(prompt +"\r\n", Color.GhostWhite);
                    return Color.WhiteSmoke;
                }

            case MessageType.Warn:
                {
                    prompt = "Сообщение Предупреждение:";
                    SendMessage(prompt + "\r\n", Color.DarkOrange);
                    return Color.Orange;
                }

            case MessageType.Debug:
                {
                    prompt = "отладочное сообщение:";
                    SendMessage(prompt + "\r\n", Color.DarkGray);
                    return Color.Gray;
                }


            case MessageType.DB:
                {
                    prompt = "Сообщение от Базы Жанных о проведенных операциях:";
                    SendMessage(prompt + "\r\n", Color.DarkBlue);
                    return Color.Blue;
                }

            case MessageType.UI:
                {
                    prompt = "Сообщение от Пользовательсткого интерфейса:";
                    SendMessage(prompt + "\r\n", Color.CadetBlue);
                    return Color.LightBlue;
                }

            case MessageType.Account:
                {
                    prompt = "Сообщение от системы работы с счетами создание и использовние имеющихся:";
                    SendMessage(prompt + "\r\n", Color.DarkSeaGreen);
                    return Color.Lime;
                }

            case MessageType.User:
                {
                    prompt = "Сообщение от системы работы с учетной записью пользоватля приложения:";
                    return Color.Yellow;
                }
            
            case MessageType.undefined:
                {
                    prompt = "Сообщение ОБщего характера:";
                    return Color.White;
                }
            default:
                return Color.White;
        }
    }
    #endregion

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
