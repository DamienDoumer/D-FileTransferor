using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FileTransferor_1._00
{
    class TransactionViewer
    {
        private DateTime dateTime;
        private int numRows;

        public TransactionViewer()
        {
            dateTime = DateTime.Now;
            numRows = CountRows();//take the number of rows so as not to have ID number != row number
        }

        public string[] RetrieveDate()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                int v = 0;
                string[] take = new string[numRows];
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.CommandText = "select DateTime from history;";
                    Command.Connection = Connect;
                    SQLiteDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        take[v] = Convert.ToString(Reader["DateTime"]);
                        v++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return take;
            }
        }
        public string[] RetrieveFileName()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                int v = 0;
                string[] take = new string[numRows];
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.CommandText = "select FileName from history;";
                    Command.Connection = Connect;
                    SQLiteDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        take[v] = Convert.ToString(Reader["FileName"]);
                        v++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return take;
            }
        }
        public string[] RetrieveFilePath()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                int v = 0;
                string[] take = new string[numRows];
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.CommandText = "select FilePath from history;";
                    Command.Connection = Connect;
                    SQLiteDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        take[v] = Convert.ToString(Reader["FilePath"]);
                        v++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return take;
            }
        }
        public string[] RetrieveDestinationPath()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                int v = 0;
                string[] take = new string[numRows];
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.CommandText = "select DestinationPath from history;";
                    Command.Connection = Connect;
                    SQLiteDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        take[v] = Convert.ToString(Reader["DestinationPath"]);
                        v++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return take;
            }
        }
        public int CountRows()
        {
            int numRows1 = 0;
            using (SQLiteConnection connect1 = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                try
                {
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.CommandText = "select count(*) from history;";//command to be executed
                    Command.Connection = connect1;
                    connect1.Open();
                    SQLiteDataReader reader = Command.ExecuteReader();//starts the reader

                    while (reader.Read())
                    {
                        numRows1 = Convert.ToInt32(reader[0]);//puts the number of rows in a variable
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return numRows1;
            }//the database will close automatically since u are using 
        }
    }
}
