using System;
using System.Media;
using System.Windows.Forms;

namespace FileTransferor_1._00
{
    class SoundPlayerr
    {
        private SoundPlayer player;

        public SoundPlayerr()
        {
            player = new SoundPlayer();
        }

        public void setSoundPath(string path)
        {
            player.SoundLocation = path;
        }

        public String getSoundPath()
        {
            return player.SoundLocation;
        }
        public void Play()
        {
            try
            {
                player.Load();
                player.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void OnTransferTerminated(object sender, EventArgs e)
        {
            Play();
        }

        public void Stop()
        {
            player.Stop();
        }
    }
}
