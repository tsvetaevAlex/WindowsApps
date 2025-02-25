namespace mdTestCreator;
using System.IO;

public class MdWriter : AppForm
{
    private string testFolderPath = string.Empty;
    private string testFilePath = string.Empty;
    private bool Is_unheadered = true;
    //private readonly string caption = "MdWriter";

    public MdWriter()
    {
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

        if (Is_unheadered)
        {
            appendline($"# Test Case: {testFileName}");
            appendline("");
            appendline("");
            appendline("|<div style = \"width:300px\" > **Test Case Description:**</div>");
            appendline("|------|");
            appendline("");
            appendline("|Step No.|Step Action|Expected Result|");
            appendline("|------|---|---|");
            Is_unheadered = false;
        }
    }

    public void AddHeader()
    {
        if (!Directory.Exists(testFolderPath))
        {
            Directory.CreateDirectory(testFolderPath);
            //MessageBox.Show($"!!REQUIRED!!!folder exists: {Directory.Exists(testFolderPath)}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Directory.SetCurrentDirectory(testFolderPath);
            // MessageBox.Show($"3.current folder is: {Directory.GetCurrentDirectory().ToString()}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public void Appendline(TestRowRecord testSTepRow)
    {
        string message = string.Empty;
        message = $"|{testSTepRow.stepNumber.Text}|{testSTepRow.stepAction}|{testSTepRow.stepExpectedResult}|";
        // 1Перенос строки в мд фпйле. первая опопытка применение /р/н;
        // 2вторая попытка Environment.NewLine;
        // 3без окончания указателей переноса строки расчет на  sw.WriteLine, WriteLine должен делать это сам.
        // 3тогда 1 2 добавляют лишнюю пустую строку и мд разметк не подхватывается, таблица не мтроится.
        //appendline(message + "\r\n"); //1 [X] лишняя  пустая строув между строками таблицы.
        //appendline(message + Environment.NewLine); //2 так же как и в первом случае есть пуская строка, (предсказуемо)
        appendline(message); //3 со строками таблицы все хорошо.
                             //есть 1 лишняя пустая строка между худером таблицы и строкми таблицы.  нвдо перепроверить внесение хедера
    }
    public void appendline(string message)
    {
        //MessageBox.Show($"3. IS TestCase file exists: {File.Exists(testFilePath)}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (!File.Exists(testFilePath))
        {
            using (File.AppendText(testFilePath)) { } // Создаем файл и сразу закрываем
        }
        else
        {
            //MessageBox.Show($"3. IS TestCase file exists: {message}", "MdWriter", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
