using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using WebAutomation.Enum;
using WebAutomation.Logger.Contract;

namespace WebAutomation.Logger
{
    public class Log
    {
        private static string logPath;

        private static string debugLog;
        private static string errorLog;
        private static string testCaseLog;
        private static string performanceLog;
        private static int visualLogLevel;
        private static bool useVisual;
        public static object Lock = new object();

        //private VisualLogger visualLogger;

        //public void SpecifyVisualForm(VisualLogger visualLoggerForm)
        //{
        //    visualLogger = visualLoggerForm;
        //}

        public static bool IsVisualLoggerEnabled()
        {
            return useVisual;
        }

        public static void SetValues(string logBasePath, string nameSpace, string testCaseName, ProjectType projectType, bool useVisualLogger = true)
        {
            useVisual = useVisualLogger;
            if (logBasePath == null) throw new Exception("Argument: logBasePath, is null");
            if (nameSpace == null) throw new Exception("Argument: nameSpace, is null");
            if (testCaseName == null) throw new Exception("Argument: testCaseName, is null");
            if (projectType == ProjectType.Undefined) throw new Exception("Argument: projectType, is Undefined");

            if (projectType == ProjectType.SmartGate)
            {
                useVisual = false;
            }

            logPath = logBasePath + GetFolderName() + @"\" + Environment.MachineName + @"\" + projectType.ToStringValue() + @"\" + 
                nameSpace + @"\Runtime_" + GetRunTime() + "_" + testCaseName + @"\";
            CreateLogger(logPath);
        }

        public static void SetValues(string logBasePath, string nameSpace, ProjectType projectType, bool useVisualLogger = true)
        {
            useVisual = useVisualLogger;
            if (logBasePath == null) throw new Exception("Argument: logBasePath, is null");
            if (nameSpace == null) throw new Exception("Argument: nameSpace, is null");
            if (projectType == ProjectType.Undefined) throw new Exception("Argument: projectType, is Undefined");

            logPath = logBasePath + GetFolderName() + @"\" + Environment.MachineName + @"\" + projectType.ToStringValue() + @"\" +
                nameSpace + @"\Runtime_" + GetRunTime() + @"\";
            CreateLogger(logPath);
        }

        private static void CreateLogger(string logPath)
        {
            errorLog = logPath + "ErrorLog.txt";
            debugLog = logPath + "DebugLog.txt";
            testCaseLog = logPath + "TestCaseLog.txt";
            performanceLog = logPath + "PerformanceLog.txt";

            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            //LoggerService.Main();
            if(useVisual)
                visualLogLevel = int.Parse(ConfigurationManager.AppSettings.Get("VISUAL_LOG_LEVEL"));
            //loggerFrame = new VisualLogger{ Visible = true, ShowInTaskbar = false };
            //LaunchHost();
        }

        public Log GetLogger()
        {
            return this;
        }

        #region Private Auxiliary methods to get logFile name and path
        /// <summary>
        /// Return logFile path
        /// </summary>
        /// <returns></returns>
        public static string GetLogFilePath()
        {
           return logPath;
        }
        
        /// <summary>
        /// Generate logFolder name
        /// </summary>
        /// <returns></returns>
        private static string GetFolderName()
        {
            /*
            var assemblyAttribute =
                (AssemblyProductAttribute)
                AssemblyProductAttribute.GetCustomAttribute
                (System.Reflection.Assembly.GetExecutingAssembly(), typeof
                (AssemblyProductAttribute));
            */
            DateTime date = DateTime.Today;
            const string dateFormat = "yyyyMMd";
            return date.ToString(dateFormat);
        }

        /// <summary>
        /// Generate logFile name
        /// </summary>
        /// <returns></returns>
        private static string GetRunTime()
        {
            DateTime date = DateTime.Now;
            const string dateFormat = "HHmmss";
            return date.ToString(dateFormat);
        }

        /// <summary>
        /// Generate date and time for log message 
        /// </summary>
        /// <returns></returns>
        private static string GetDateTime()
        {
            DateTime date = DateTime.Now;
            const string dateFormat = "yyyy-MM-d HH:MM:ss.ffff";
            return date.ToString(dateFormat);
        }
        #endregion

        /// <summary>
        /// Write Log Message Core
        /// </summary>
        /// <param name="logType">logFile to use</param>
        /// <param name="logLevel">log level: DEBUG | INFO | WARNING | ERROR | FATAL | PERFORMANCE</param>
        /// <param name="logMessage">>message to log</param>
        /// <param name="iLogLevel"></param>
        private static void WriteLog
            (string logType, LogLevel logLevel, string logMessage, int iLogLevel = 0)
        {

            lock (Lock)
            {
                using (StreamWriter sw = File.AppendText(logType))
                {
                    var stackTrace = new StackTrace();
                    var method = stackTrace.GetFrame(2).GetMethod();
                    string methodName = method.Name;
                    var Class = method.ReflectedType;

                    sw.WriteLine("{0} {1}.{2} {3}: {4}",
                        GetDateTime(), Class.FullName, methodName, logLevel, logMessage);
                }
            }

            if (iLogLevel == 0) return;
            if (iLogLevel > visualLogLevel) return;

            //WriteTextAsync(logLevel, logMessage);
            //loggerFrame.WriteText(logLevel, logMessage);
            if(useVisual)
                SendToVisual(logLevel, logMessage);
            //TODO: connect to service => send msg => disconnect

        }

        private static void StopLogger()
        {
            Uri tcpUri = new Uri("http://localhost:4000/TestService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            //var logger = new LogReceiver();
            ChannelFactory<IVisualLogger> factory = new ChannelFactory<IVisualLogger>(binding, address);
            IVisualLogger service = factory.CreateChannel();

            service.StopLogger();
        }

        public static void SendToVisual(LogLevel logLevel, string logMessage)
        {
            Uri tcpUri = new Uri("http://localhost:4000/TestService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            //var logger = new LogReceiver();
            ChannelFactory<IVisualLogger> factory = new ChannelFactory<IVisualLogger>(binding, address);
            IVisualLogger service = factory.CreateChannel();

            service.SendMessageToVisualLogger(logLevel, logMessage);

            //Console.WriteLine("Call service...?");
            //Console.WriteLine(service.GetCommandString(1));

            //switch (logLevel)
            //{
            //    case LogLevel.Debug: service.Debug(logMessage);
            //        break;
            //    case LogLevel.Info: service.Info(logMessage);
            //        break;
            //    case LogLevel.TestCase: service.TestCase(logMessage);
            //        break;
            //    case LogLevel.Warning: service.Warning(logMessage);
            //        break;
            //    case LogLevel.Error: service.Error(logMessage);
            //        break;
            //    case LogLevel.Fatal: service.Fatal(logMessage);
            //        break;
            //    case LogLevel.Performance: service.Performance(logMessage);
            //        break;
            //    case LogLevel.Screenshot: service.Screenshot(logMessage);
            //        break;
            //    default: service.Debug(logMessage);
            //        break;
            //}
            //service.Debug(logMessage);

            //service.
        }


        #region Public Methods to Write Log Message
        /// <summary>
        /// Write DEBUG level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Debug(string message)
        {
            WriteLog(debugLog, LogLevel.Debug, message, 4);
        }

        /// <summary>
        /// Write INFO level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Info(string message)
        {
            WriteLog(debugLog, LogLevel.Info, message, 3);
        }

        /// <summary>
        /// Write WARNING level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Warning(string message)
        {
            WriteLog(debugLog, LogLevel.Warning, message);
            WriteLog(errorLog, LogLevel.Warning, message, 2);
        }

        /// <summary>
        /// Write ERROR level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Error(string message)
        {
            WriteLog(debugLog, LogLevel.Error, message);
            WriteLog(errorLog, LogLevel.Error, message, 2);
        }

        /// <summary>
        /// Write FATAL level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Fatal(string message)
        {
            WriteLog(debugLog, LogLevel.Fatal, message);
            WriteLog(errorLog, LogLevel.Fatal, message, 2);
        }

        /// <summary>
        /// Write PERFORMANCE level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Performance(string message)
        {
            WriteLog(performanceLog, LogLevel.Performance, message, 3);
            WriteLog(debugLog, LogLevel.Performance, message);
        }

        /// <summary>
        /// Write TESTCASE level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void TestCase(string message)
        {
            WriteLog(testCaseLog, LogLevel.TestCase, message, 1);
            WriteLog(debugLog, LogLevel.TestCase, message);
        }

        /// <summary>
        /// Write SCREENSHOT level log message 
        /// </summary>
        /// <param name="message">log message</param>
        public static void Screenshot(string message)
        {
            WriteLog(debugLog, LogLevel.Screenshot, message, 2);
        }

        public static void SetWindowTitle(string WindowTitle)
        {
            Uri tcpUri = new Uri("http://localhost:4000/TestService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            //var logger = new LogReceiver();
            ChannelFactory<IVisualLogger> factory = new ChannelFactory<IVisualLogger>(binding, address);
            IVisualLogger service = factory.CreateChannel();

            service.SetWindowTitle(WindowTitle);
        }

        public static void StopVisualLogger()
        {
            StopLogger();
        }

        #endregion
    }
}
