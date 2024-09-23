using MySqlConnector;
using System.Configuration;

namespace mdTestCreator;

class SqlWrapper
{
    private readonly string db_host = string.Empty;
    private readonly string db_name = string.Empty;
    private readonly string db_user = string.Empty;
    private readonly string db_pswd = string.Empty;
    public static MySqlConnection sqlConnection;
    private static string ConnectionString = "";
    private const string sqlWrapperCaption = "message from sqslWrapper.";

    public SqlWrapper()
    {
        db_host = ConfigurationManager.AppSettings["db_Host"];
        db_name = ConfigurationManager.AppSettings["db_name"];
        db_user = ConfigurationManager.AppSettings["db_User"];
        db_pswd = ConfigurationManager.AppSettings["db_pswd"];

        ConnectionString = $"server={db_host};user={db_user};password={db_pswd};";
    }

    public void InitDB()
    {
        sqlConnection = Get_db_Connection(); //this.code line 84
        if (sqlConnection != null)
        {
            try
            {
                string createDatabaseQuery = $"CREATE DATABASE IF NOT EXISTS {db_name};";
                MySqlCommand create_db_cmd = new MySqlCommand(createDatabaseQuery, sqlConnection);
                create_db_cmd.CommandText = createDatabaseQuery;
                int createResult = create_db_cmd.ExecuteNonQuery();
                if (createResult == 1)
                {
                    MessageBox.Show("DataBase created", sqlWrapperCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Database created successfully.");
                }


                #region create table, queries
                string createTableTests = "CREATE TABLE tests(id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, title varchar(255), description varchar(255), int steporder int, stepid int);";
                /* example
                 INSERT INTO tests (title, description, steporder, stepid)
                VALUES ('Первый тест', 'Описание первого теста', 1, 101);
                 */
                string createTsbleSteps = "CREATE TABLE steps(PRIMARY_KEY_COLUMN INT NOT NULL AUTO_INCREMENT,description varchar(255),expected varchar(255));";
                string createTableReport = "CREATE TABLE report (PRIMARY_KEY_COLUMN INT NOT NULL AUTO_INCREMENT ... PRIMARY KEY (PRIMARY_KEY_COLUMN));";
                #endregion

                if (sqlConnection != null)
                {
                    //TABLE tests
                    #region create tsbles tests;
                    //TABLE tests
                    Console.WriteLine($"db connecyion is: {sqlConnection}");
                    using (MySqlCommand command_tests = new MySqlCommand(createTableTests, sqlConnection))
                    {
                        // Execute the command to create the database
                        command_tests.ExecuteNonQuery();
                        Console.WriteLine("TABLE created successfully.");
                    }
                    #endregion
                    //TABLE steps
                    #region create tsbles steps;
                    using (MySqlCommand command_teps = new MySqlCommand(createTsbleSteps, sqlConnection))
                    {
                        // Execute the command to create the database
                        command_teps.ExecuteNonQuery();
                        Console.WriteLine("Database created successfully.");
                    }
                    #endregion
                    //TABLE Report
                    #region create tsbles report;
                    using (MySqlCommand command_reports = new MySqlCommand(createTableReport, sqlConnection))
                    {
                        // Execute the command to create the database
                        command_reports.ExecuteNonQuery();
                        Console.WriteLine("Database initiated successfully.");
                    }
                    #endregion
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception has been thrown: {e.Message}");
            }
        }// End of InitDB()
    }

    public static MySqlConnection Get_db_Connection()
    {
        while (true)
        {
            try
            {
                sqlConnection = new MySqlConnection(ConnectionString);
                sqlConnection.Open();
                if (sqlConnection != null)
                {
                    return sqlConnection;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"we got an exception in oprning DB connection: {e.Message}", "exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }// end of while(true){}

    }// end of Get_db_Connection


    public static int Get_lastID()
    {
        int rteurnValue = 1;
        string query = "SELECT LAST_INSERT_ID();";
        using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
        {
            // Execute the command to create the database
            command.ExecuteNonQuery();
            Console.WriteLine("Database created successfully.");

        }
        return rteurnValue;
    }

    public static void ShowDbConnectionState()
    {
        MessageBox.Show($"connection state:{sqlConnection}", sqlWrapperCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
} // end of class.
