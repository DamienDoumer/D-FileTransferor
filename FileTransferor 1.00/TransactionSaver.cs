using System;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileTransferor_1._00
{
    class TransactionSaver
    {
        private DateTime dateTime;
        private string fileName;
        private string filePath;
        private string destinationPath;
        private int numRows;

        public int NumRows
        {
            get { return numRows; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; } 
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public string DestinationPath
        {
            get { return destinationPath; }
            set { destinationPath = value; }
        }
        public TransactionSaver()
        {
            destinationPath = null;
            dateTime = DateTime.Now;
            filePath = null;
            fileName = null;
            numRows = CountRows();//take the number of rows so as not to have ID number != row number
        }

        public void ResetStepByStep()//I removed the ID so it wont work here
        {
            using (SQLiteConnection Con = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                SQLiteCommand Cmd = new SQLiteCommand();
                numRows = CountRows();
                int i = 1;
                string cmdText = null;
                Con.Open();//open the data base before executing any command
                while (i <= numRows)//delete the content of each tuple one by one
                {
                    try
                    {
                        cmdText = "delete from history where ID = " + i + ";";
                        Cmd.CommandText = cmdText;
                        Cmd.Connection = Con;
                        int L = Cmd.ExecuteNonQuery();

                        if (L == 1)
                        {
                            ;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    i++;
                }
            }
        }   
        public void Reset()//this will reset the 2 databases used by the application
        {
            using (SQLiteConnection Con = new SQLiteConnection("Data Source = History.db; version = 3;"))
            using (SQLiteConnection Con1 = new SQLiteConnection("Data Source = Paths.db; version = 3;"))
            {
                SQLiteCommand Cmd = new SQLiteCommand();
                SQLiteCommand Cmd1 = new SQLiteCommand();
                try
                {
                    Con.Open();
                    Con1.Open();
                    string Txt = "delete from history";
                    string txt1 = "delete from paths";
                    Cmd.CommandText = Txt;
                    Cmd1.CommandText = txt1;
                    Cmd.Connection = Con;
                    Cmd1.Connection = Con1;
                    int L = Cmd.ExecuteNonQuery();//this is to verify if the query was executed and to ensure its execution
                    int L1 = Cmd1.ExecuteNonQuery();

                    if (L == 1&&L1 == 1)//check for both queries
                    {
                        ;
                    }
                    numRows = 0;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public void Save()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = History.db; version = 3;"))
            {
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    numRows = CountRows();//get the new num  of rows at each moment when method is called
                    int n = numRows + 1;//increment the number of rows so that the ID should be the same as the nuber of rows in the table
                    string fp = RemoveUnwantedChar('\'',filePath);//this is to remove any char which will
                    fp = RemoveUnwantedChar(',', fp);//Interfere with the functioning of the sql command
                    filePath = fp;
                    fileName = Path.GetFileName(filePath);

                    string Txt = "insert into history (FileName, FilePath, DestinationPath, DateTime)" +
                                 " values ( '" + fileName + "', '" + filePath + "', '" + destinationPath + "', '" +
                                 dateTime + "');";
                    Command.CommandText = Txt;
                    Command.Connection = Connect;
                    int L = Command.ExecuteNonQuery();//v is used to ensure that the query executes.

                    if (L == 1)
                    {
                        ;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
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
                    Command.CommandText = "select count(*) from history;";//command to be executed that counts the number of rows in a table
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

        private string RemoveUnwantedChar(char character, string txt)
        {
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] != character)
                {
                    build.Append(txt[i]);
                }
            }
            return Convert.ToString(build);
        }
    }
}
