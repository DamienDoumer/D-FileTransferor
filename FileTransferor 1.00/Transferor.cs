using System;
using System.IO;
using System.Windows.Forms;

namespace FileTransferor_1._00
{
    class Transferor
    {
        private PathManager Paths;
        private string[] destinationPaths;
        private TransactionSaver Saver;
        private string filePath;
        private string finalDestinationPath;

        public delegate void TransferTerminatedEventHandler(object sender, EventArgs e);
        public event TransferTerminatedEventHandler TransferTerminated;

        public string[] getDestinationPath()
        {
            return destinationPaths;
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string FinalDestination
        {
            get { return finalDestinationPath; }
            set { finalDestinationPath = value; }
        }
        public Transferor()
        {
            Paths = new PathManager();
            Saver = new TransactionSaver();
            destinationPaths = new string[7];
            destinationPaths = Paths.RetrievePaths();
            filePath = null;
            finalDestinationPath = null;
        }

        public virtual void OnTransferTerminated()
        {
            if (TransferTerminated != null)
            {
                TransferTerminated(this, EventArgs.Empty);
            }
        }
        public void Decide()
        {
            int v = 0;
            for (int j = 0; j < Paths.getPictureExtentions().Length; j++)//end the loop when there is no more extention to test
            {
                if (Paths.getPictureExtentions()[j] == Path.GetExtension(filePath))
                {
                    v = 1;
                    finalDestinationPath = destinationPaths[2];
                    break;//stop looping when an extention is found to match
                }
            }
            if (v == 0)//dont bother to test for an extention if one was found to match
            {
                for (int j = 0; j < Paths.getMusicExtentions().Length; j++)//end the loop when there is no more extention to test
                {
                    if (Paths.getMusicExtentions()[j] == Path.GetExtension(filePath))
                    {
                        v = 1;
                        finalDestinationPath = destinationPaths[4];
                        break;//stop looping when an extention is found to match
                    }
                }
            }
            if (v == 0)//dont bother to test for an extention if one was found to match b/c v is increments whn extention matches and destination is set
            {
                for (int j = 0; j < Paths.getVideoExtentions().Length; j++)//end the loop when there is no more extention to test
                {
                   
                    if (Paths.getVideoExtentions()[j] == Path.GetExtension(filePath))
                    {
                        v = 1;
                        finalDestinationPath = destinationPaths[1];
                        break;//stop looping when an extention is found to match
                    }
                }
            }
            if (v == 0)//dont bother to test for an extention if one was found to match b/c v is increments whn extention matches and destination is set
            {
                for (int j = 0; j < Paths.getMovieExtentions().Length; j++)//end the loop when there is no more extention to test
                {
                    if (Paths.getMovieExtentions()[j] == Path.GetExtension(filePath))
                    {
                        v = 1;
                        finalDestinationPath = destinationPaths[0];
                        break;//stop looping when an extention is found to match
                    }
                }
            }
            if (v == 0)//dont bother to test for an extention if one was found to match b/c v is increments whn extention matches and destination is set
            {
                for (int j = 0; j < Paths.getDocumentExtentions().Length; j++)//end the loop when there is no more extention to test
                {
                    if (Paths.getDocumentExtentions()[j] == Path.GetExtension(filePath))
                    {
                        v = 1;
                        finalDestinationPath = destinationPaths[3];
                        break;//stop looping when an extention is found to match
                    }
                }
            }
            if(v==0)
            {
                finalDestinationPath = destinationPaths[6];
            }
        }

        public void CloudCopy()
        {
            string fileName = null, destination = null;
            try
            {
                fileName = Path.GetFileName(filePath);
                finalDestinationPath = destinationPaths[5];
                destination = Path.Combine(finalDestinationPath, fileName);
            }
            catch
            {
                MessageBox.Show("Please set your directories before copying a file");
            }
            if (finalDestinationPath != null)
            {
                if (!Directory.Exists(finalDestinationPath))
                {
                    MessageBox.Show(
                        "The directory where this file is to be copied may not exist.\nPlease change your directories",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        File.Copy(filePath, destination);
                        Save(); //save information about this copy
                        OnTransferTerminated();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        public void CsharpCopy()
        {
            try
            {
                string fileName = Path.GetFileName(filePath);
                string destination = Path.Combine(finalDestinationPath, fileName);
                if (!Directory.Exists(finalDestinationPath))
                {
                    MessageBox.Show(
                        "The directory where this file is to be copied does not exist.\nPlease change your directories",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        File.Copy(filePath, destination);
                        Save(); //save information about this copy
                        OnTransferTerminated();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Please set your directories first"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void CsharpSend()
        {
            try
            {
                string fileName = Path.GetFileName(filePath);
                string destination = Path.Combine(finalDestinationPath, fileName);
                if (!Directory.Exists(finalDestinationPath))
                {
                    MessageBox.Show(
                        "The directory where this file is to be sent does not exist.\nPlease change your directories",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        File.Move(filePath, destination);
                        Save(); //saves information about this transfer
                        OnTransferTerminated();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please set your directories first"
                   , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Save()
        {
            Saver.DateTime = DateTime.Now;
            Saver.DestinationPath = finalDestinationPath;
            Saver.FilePath = filePath;
            Saver.FileName = Path.GetFileName(filePath);
            Saver.Save();
        }
    }
}
