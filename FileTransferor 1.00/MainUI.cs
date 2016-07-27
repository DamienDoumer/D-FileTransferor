using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace FileTransferor_1._00
{
    public partial class FileTransferorUI : Form
    {
        private SoundPlayerr play;
        private TransactionSaver saver;
        //private Transferor transferor;
        private Queue<Transferor> qeueTransfers;
        int fileCount = 0;
        private SoundPlayerr player;
       
        public FileTransferorUI()
        {
            InitializeComponent();

            play = new SoundPlayerr();
            saver = new TransactionSaver();
            qeueTransfers = new Queue<Transferor>();
            //transferor = new Transferor();
            player = new SoundPlayerr();

            //this.DragEnter += new DragEventHandler(panel1_DragEnter);
            //this.DragDrop += new DragEventHandler(panel1_DragDrop);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (player.getSoundPath().Length > 1)
                {
                    player.Stop();
                }
                int i = 0;
                string[] fileList = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
                //get filepaths of droped files
                fileCount = fileList.Length + fileCount; //counts num of file droped
                label3.Text = fileCount + @" File(s) Droped";
                StreamReader reader = new StreamReader("Sound.txt");
                string r = reader.ReadLine(); 
                reader.Close();
                player.setSoundPath(r == null ? "Transfer Completed.wav" : r);

                qeueTransfers = new Queue<Transferor>();
                while (i < fileList.Length)//using filecount will not be exact cause its value is stored when it increases(out of scope)
                {
                    Transferor transferor = new Transferor();
                    transferor.FilePath = fileList[i];
                    transferor.TransferTerminated += player.OnTransferTerminated;
                    transferor.Decide();
                    qeueTransfers.Enqueue(transferor);
                    i++;
                }
                if (fileList.Length > 1)
                {
                    Transferor t = new Transferor();
                    //this is to put a last element to ensure that all elements of the qeue are transfered
                    qeueTransfers.Enqueue(t);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Stop();
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to reset this app ?" +
                                                      "\nDoing So will delete all user data", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saver.Reset();
                    MessageBox.Show("Reset complete\n" +
                                    "Please Restart your app to fully reset it."
                        , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                StreamWriter writer = new StreamWriter("Sound.txt");
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Stop();
            History_View hViewer = new History_View();
            DialogResult result = hViewer.ShowDialog();
            hViewer = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            try
            {
                progressBar1.Show();
                label3.Text = null;
                progressBar1.Enabled = true;
                progressBar1.PerformStep();

                if (qeueTransfers.Count < 1)
                {
                    MessageBox.Show("No file was droped to the panel please drop a file before" +
                                    " Copying or Sending a file.", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i <= qeueTransfers.Count; i++)
                    {
                        Transferor tr = qeueTransfers.Dequeue();
                        Thread thr = new Thread(new ThreadStart(tr.CsharpSend));
                        thr.Start();
                    }
                    label3.Text = "Transfer Completed!";
                }
                qeueTransfers = new Queue<Transferor>();
                fileCount = 0;
                progressBar1.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.Stop();
            Set_Paths setP = new Set_Paths();
            DialogResult result = setP.ShowDialog();
            setP = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
            try
            {
                progressBar1.Show();
                label3.Text = null;
                progressBar1.Enabled = true;
                progressBar1.PerformStep();

                if (qeueTransfers.Count < 1)
                {
                    MessageBox.Show("No file was droped to the panel please drop a file before" +
                                    " Copying or Sending a file.", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i <= qeueTransfers.Count; i++)
                    {
                        Transferor tr = qeueTransfers.Dequeue();
                        Thread thr = new Thread(new ThreadStart(tr.CloudCopy));
                        thr.Start();
                    }
                    label3.Text = "Copy Completed!";
                }
                qeueTransfers = new Queue<Transferor>();
                fileCount = 0;
                progressBar1.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            try
            {
                progressBar1.Show();
                label3.Text = null;
                progressBar1.Enabled = true;
                progressBar1.PerformStep();

                if (qeueTransfers.Count < 1)
                {
                    MessageBox.Show("No file was droped to the panel please drop a file before" +
                                    " Copying or Sending a file.", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i <= qeueTransfers.Count; i++)
                    {
                        Transferor tr = qeueTransfers.Dequeue();
                        Thread thr = new Thread(new ThreadStart(tr.CsharpCopy));
                        thr.Start();
                    }
                    label3.Text = "Copy Completed!";
                }
                qeueTransfers = new Queue<Transferor>();
                fileCount = 0;
                progressBar1.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            About_App abt = new About_App();
            DialogResult result = abt.ShowDialog();
            abt = null;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            How_to_use_it h = new How_to_use_it();
            DialogResult result = h.ShowDialog();
            h = null;
        }

        private void changeSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            Change_Sound s = new Change_Sound();
            DialogResult result = s.ShowDialog();
            s = null;
        }

        private void FileTransferorUI_MouseClick(object sender, MouseEventArgs e)
        {
            player.Stop();//stop the sound when the user seems to have noticed the transfer completed
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            player.Stop();
        }
    }
}
