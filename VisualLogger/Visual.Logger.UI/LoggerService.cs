using System;
using System.ServiceModel;
using System.Windows.Forms;
using Visual.Logger.Contract;

namespace Visual.Logger.Service
{

    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.Single
    )]
    public class LoggerService
    {
        private static ServiceHost _host;
        private static VisualLogger _visualLoggerForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(false);

                //VisualLogger _visualLoggerForm = new VisualLogger();
                _visualLoggerForm = new VisualLogger();
                LogReceiver logReceiver = new LogReceiver(_visualLoggerForm);
                _host = new ServiceHost(logReceiver, new Uri("http://localhost:4000/TestService"));
                _host.AddServiceEndpoint(typeof(IVisualLogger), new BasicHttpBinding(), "");

                _host.Open();

                Application.EnableVisualStyles();

                Application.Run(_visualLoggerForm);

                int i = 0;
                i++;
                //_host.Close();
            }
            catch (Exception)
            {
                // The user refused the elevation.
                // Do nothing and return directly ...
                return;
            }
        }

        public static void StopVisualLogger()
        {
            _visualLoggerForm.Close();
            _host.Close();
            Application.Exit();
        }

    }
}
