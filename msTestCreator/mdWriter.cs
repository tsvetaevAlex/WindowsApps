namespace mdTestCreator;
using System.IO;

public class MdWriter : AppForm
{
    private string testFolderPath = string.Empty;
    private string testFilePath = string.Empty;
    //private readonly string caption = "MdWriter";

    public MdWriter()
    {
        LogsBox.Text += "MdWriter.Constructor()"+Environment.NewLine;
        testFileName = $"{AppForm.testFileName}{AppForm.FileEextension}";// attch file extension to file name.
        testFolderPath = Path.Combine(Environment.CurrentDirectory, testFolder);// full path to our tsrget folder
        testFilePath = Path.Combine(testFolderPath, testFileName); // full path to output target file.
        bool isTestFolderExistst = Directory.Exists(testFolderPath);
        if (!isTestFolderExistst)
        {
            Directory.CreateDirectory(testFolderPath);
            Directory.SetCurrentDirectory(testFolderPath); // set focus to target folder.
        }
        else
        {
            Directory.SetCurrentDirectory(testFolderPath);
        }
        testFilePath = Path.Combine(testFolderPath, testFileName); // full path to output target file.
        using (StreamWriter testFile = File.AppendText(testFilePath)){ // } Создаем файл и сразу закрываем
        }

    }
    public void AddHeader()
    {
        MessageBox.Show($"AddHeader|{Header.testFileName}{Environment.NewLine}|{Header.testDeacription}|", "AddHeader", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //LogsBox.Text += ($"AddHeader|{stepsQTY}|{Header.testFileName}{Environment.NewLine}|{Header.testDeacription}|");

        LogsBox.Text += "MdWriter.AddHeader()" + Environment.NewLine;
        LogsBox.Text += "Header.testFileName" + Environment.NewLine;
        LogsBox.Text += "Header.testDeacription" + Environment.NewLine;

        //AppForm.LogsBox.Text += $"MdWriter.AddHeader();{Environment.NewLine}";

        //MessageBox.Show($"1. folder exists: {Directory.Exists(testFolderPath)}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (!Directory.Exists(testFolderPath))
        {
            Directory.CreateDirectory(testFolderPath);
            //MessageBox.Show($"!!REQUIRED!!!folder exists: {Directory.Exists(testFolderPath)}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Directory.SetCurrentDirectory(testFolderPath);
           // MessageBox.Show($"3.current folder is: {Directory.GetCurrentDirectory().ToString()}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            appendline($"# Test Case: {testFileName}");
            appendline("");
            appendline("|<div style = \"width:300px\" > **Test Case Description:**</div>");
            appendline("|------|");
            appendline("");
            appendline("|Step No.|Step Action|Expected Result|");
            appendline("|------|---|---|");
            appendline("");
        }
    }

    public void Appendline(TestRowRecord testSTepRow)
    {
        string message = string.Empty;
        message = $"|{testSTepRow.stepNumber.Text}|{testSTepRow.stepAction}|{testSTepRow.stepExpectedResult}|";
        LogsBox.Text += (message+Environment.NewLine);
        appendline(message);
        appendline("");

    }
    public void appendline(string message)
    {
        LogsBox.Text += "MdWriter.appendline(): " + Environment.NewLine;
        LogsBox.Text += $"message:{message}" + Environment.NewLine;
        //AppForm.LogsBox.Text += $"MdWriter.appendline();{Environment.NewLine}";
        //AppForm.LogsBox.Text += $"+>{message};{Environment.NewLine}";

        //MessageBox.Show($"3. IS TestCase file exists: {File.Exists(testFilePath)}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (!File.Exists(testFilePath))
        {
            using (File.Create(testFilePath)) { } // Создаем файл и сразу закрываем
        }
        else
        {
            object thisLock = new object();
            lock (thisLock)
            {
                using (FileStream fStream = new FileStream(testFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                using (StreamWriter sw = new StreamWriter(fStream))
                {
                    sw.WriteLine(message);
                }// end of StreamWriter
            }// End of lock (thisLock)
        }// end of lock else statement

    }// End of appendline
}// end of class

