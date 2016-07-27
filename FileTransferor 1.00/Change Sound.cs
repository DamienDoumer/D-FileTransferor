using System;
using System.Windows.Forms;
using System.IO;

namespace FileTransferor_1._00
{
    public partial class Change_Sound : Form
    {
        public Change_Sound()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.DefaultExt = "wav";
                this.openFileDialog1.Filter = "wav files (*.wav)|*.wav";

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    textBox1.Enabled = false;
                    StreamWriter writer = new StreamWriter("Sound.txt");
                    writer.WriteLine(textBox1.Text);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Sound_Load(object sender, EventArgs e)
        {

        }
    }
}
