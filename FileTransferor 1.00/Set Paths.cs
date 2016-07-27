using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransferor_1._00
{
    public partial class Set_Paths : Form
    {
        PathManager pathManager;
        private string[] paths;
        public Set_Paths()
        {
            InitializeComponent();
            pathManager = new PathManager();
            paths = new string[8];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;
    
                if (result == DialogResult.OK)
                {
                    pathManager.VideoPath = folderBrowserDialog1.SelectedPath;
                    paths[6] = pathManager.VideoPath;
                    textBox6.Text = folderBrowserDialog1.SelectedPath;
                    textBox6.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;

                if (result == DialogResult.OK)
                {
                    pathManager.CloudPath = folderBrowserDialog1.SelectedPath;
                    paths[1] = pathManager.CloudPath;
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                    textBox1.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;

                if (result == DialogResult.OK)
                {
                    pathManager.MoviePath = folderBrowserDialog1.SelectedPath;
                    paths[2] = pathManager.MoviePath;
                    textBox2.Text = folderBrowserDialog1.SelectedPath;
                    textBox2.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;

                if (result == DialogResult.OK)
                {
                    pathManager.DocumentPath = folderBrowserDialog1.SelectedPath;
                    paths[3] = pathManager.DocumentPath;
                    textBox3.Text = folderBrowserDialog1.SelectedPath;
                    textBox3.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;
    
                if (result == DialogResult.OK)
                {
                    pathManager.PicturePath = folderBrowserDialog1.SelectedPath;
                    paths[4] = pathManager.PicturePath;
                    textBox4.Text = folderBrowserDialog1.SelectedPath;
                    textBox4.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;
            
                if (result == DialogResult.OK)
                {
                    pathManager.MusicPath = folderBrowserDialog1.SelectedPath;
                    paths[5] = pathManager.MusicPath;
                    textBox5.Text = folderBrowserDialog1.SelectedPath;
                    textBox5.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;
     
                if (result == DialogResult.OK)
                {
                    pathManager.DefaultPath = folderBrowserDialog1.SelectedPath;
                    paths[7] = pathManager.DefaultPath;
                    textBox7.Text = folderBrowserDialog1.SelectedPath;
                    textBox7.Enabled = false;
                    pathManager.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int v = 0;
            try
            {
                for (int i = 0; i < paths.Length; i++)
                {
                    if (paths[i] != null)
                    {
                        v++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (v < 7)
            {
                MessageBox.Show("Please set all your directiories before closing this dialog"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Please restart your app to fully set the directories", "Information");
                this.Close();
            }
        }
    }
}
