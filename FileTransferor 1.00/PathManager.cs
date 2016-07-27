using System;
using System.Data.SQLite;
using System.Windows.Forms;


namespace FileTransferor_1._00
{
    public class PathManager
    {
        private string musicPath;
		private string moviePath;
		private string videoPath;
		private string documentsPath;
		private string cloudPath;
		private string picturePath;
		private string defaultPath;
		private string[] musicExtentions;
		private string[] movieExtentions;
		private string[] videoExtentions;
		private string[] documentsExtentions;
		private string[] pictureExtentions;
		static int numberOfPathsSet;//for the number of paths which has been set

		public String[] getMovieExtentions()
		{
			return movieExtentions;
		}
		public String[] getMusicExtentions()
		{
			return musicExtentions;
		}
		public String[] getDocumentExtentions()
		{
			return documentsExtentions;
		}
		public String[] getPictureExtentions()
		{
			return pictureExtentions;
		}
		public String[] getVideoExtentions()
		{
			return videoExtentions;
		}

		public String MusicPath
		{
			get{ return musicPath; }
            set { this.musicPath = value; }
		}
		public String VideoPath
		{
			get { return videoPath; }
			set { this.videoPath = value; }
		}
		public String DocumentPath
		{
			get { return documentsPath; }
			set { this.documentsPath = value; }
		}
		public String CloudPath
		{
			get { return cloudPath; }
			set { this.cloudPath = value; }
		}
		public String DefaultPath
		{
			get { return this.defaultPath; }
			set { this.defaultPath = value; }
		}
		public String MoviePath
		{
			get { return this.moviePath; }
			set { this.moviePath = value; }
		}
		public String PicturePath
		{
			get { return this.picturePath; }
			set { this.picturePath = value; }
		}
		public PathManager(string musicPath, string moviePath, string videoPath, string documentsPath, string cloudPath,
			string picturePath, string defaultPath)
		{
			defaultPath = this.defaultPath;
			musicPath = this.moviePath;
			moviePath = this.moviePath;
			videoPath = this.videoPath;
			documentsPath = this.documentsPath;
			cloudPath = this.cloudPath;
			defaultPath = this.defaultPath;
			numberOfPathsSet = 7;

            movieExtentions = new string[] { ".avi", ".mpeg", ".mov", ".mkv", ".m4v", ".divx" }; ;
            musicExtentions = new string[] { ".mka", ".wav", ".mp3", ".wav", ".mp1", ".mp2", ".mpc", ".flac" };
            videoExtentions = new string[] { ".mp4", ".flv", ".3gp", ".webm" };
            documentsExtentions = new string[] { ".pdf", ".docx", ".rtf", ".xdp", ".ppdf", ".fdf", ".xfd", ".txt"};
            pictureExtentions = new string[] { ".jpeg", ".jpg", ".png", ".bmp", ".JPG" };


		}

		public PathManager()
		{
			defaultPath = null;
			musicPath = null;
			moviePath = null;
			videoPath = null;
			documentsPath = null;
			cloudPath = null;
			defaultPath = null;
			numberOfPathsSet = 0;

			movieExtentions = new string[]{".avi", ".mpeg", ".mov", ".mkv", ".m4v", ".divx"};
			musicExtentions = new string[]{".mka", ".wav", ".mp3", ".wav", ".mp1", ".mp2", ".mpc", ".flac", ".m4v"}; 	
			videoExtentions = new string[]{".mp4", ".flv", ".3gp", ".webm"};
            documentsExtentions = new string[]{ ".pdf", ".docx", ".rtf", ".xdp", ".ppdf", ".fdf", ".xfd", ".txt"};
			pictureExtentions = new string[]{ ".jpeg", ".jpg", ".png", ".bmp", ".JPG" };
		}

        public void Reset()
        {
            using (SQLiteConnection Con = new SQLiteConnection("Data Source = Paths.db; version = 3;"))
            {
                SQLiteCommand Cmd = new SQLiteCommand();
                try
                {
                    Con.Open();
                    string Txt = "delete from paths";
                    Cmd.CommandText = Txt;
                    Cmd.Connection = Con;
                    int L = Cmd.ExecuteNonQuery();//this is to verify if the query was executed and to ensure its execution

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

        public string[] RetrievePaths()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = Paths.db; version = 3;"))
            {
                int v = 0;
                string[] take = new string[7];
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Command.CommandText = "select * from paths;";
                    Command.Connection = Connect;
                    SQLiteDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        take[v] = Convert.ToString(Reader["MoviePath"]);
                        v++;
                        take[v] = Convert.ToString(Reader["VideoPath"]);
                        v++;
                        take[v] = Convert.ToString(Reader["PicturePath"]);
                        v++;
                        take[v] = Convert.ToString(Reader["DocumentsPath"]);
                        v++;
                        take[v] = Convert.ToString(Reader["MusicPath"]);
                        v++;
                        take[v] = Convert.ToString(Reader["CloudPath"]);
                        v++;
                        take[v] = Convert.ToString(Reader["DefaultPath"]);
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

        public void Save()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = Paths.db; version = 3;"))
            {
                try
                {
                    Connect.Open();
                    SQLiteCommand Command = new SQLiteCommand();
                    Reset();//let there be only one destination path for each file type
                    int n = 1;//increment the number of rows so that the ID should be the same as the nuber of rows in the table
                    string Txt = "insert into paths (ID, MoviePath, "+
                        "VideoPath, PicturePath, DocumentsPath, MusicPath, CloudPath, DefaultPath)" +
                        " values ( " + n + ", '" + moviePath + "', '" + videoPath + 
                        "', '" + picturePath + "', '" + documentsPath + "', '"+musicPath+"', '"+cloudPath+"', '"+
                        defaultPath+"');";
                    
                    Command.CommandText = Txt;
                    Command.Connection = Connect;
                    int L = Command.ExecuteNonQuery();//v is used to ensure that the query

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
	}
}
