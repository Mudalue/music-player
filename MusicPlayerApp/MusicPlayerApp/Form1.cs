using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //Create Global variable of string type array to save the titles or name of the track and path of the track
        string[] Path, Files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //code to select multiple music files
            ofd.Multiselect = true;


            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Files = ofd.SafeFileNames; //save the names of the track in array

                Path = ofd.FileNames;//save the path of the track in path array
                
                //Display the music title in list box
                for (int i = 0; i < Files.Length; i++)
                {
                    listBoxSong.Items.Add(Files[i]); //Display Songs in List Box
                }
            }
        }

        private void listBoxSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write code to play music
            axWindowsMediaPlayerMusic.URL = Path[listBoxSong.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close app
            this.Close();
        }
    }
}
