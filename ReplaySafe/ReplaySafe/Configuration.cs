using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaySafe
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String path = osupath.Text;
            if (IsOsuFolder(path))
            {
                // Set variables
                OsuPath = osupath.Text;
                BackupPath = savepath.Text;

                // Save config
                String[] config = {OsuPath, BackupPath};
                SaveConfiguration(config);

                // Hide frame
                this.Hide();

                // Start Saver
                Program.StartSafer();

                // Close frame
                this.Close();
            }
            else
            {
                MessageBox.Show("Not a valid Osu folder!", "Wrong path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static bool IsOsuFolder(String folder)
        {
            bool exists = true;

            if (!Directory.Exists(folder + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar + "r"))
                exists = false;

            if (!Directory.Exists(folder + Path.DirectorySeparatorChar + "Replays"))
                exists = false;

            return exists;
        }


        public static String OsuPath = "";
        public static String BackupPath = "";

        public static String ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "OsuReplaySafe.conf";

        public static bool LoadConfiguration()
        {
            try
            {
                // Loads config file from appdata into fields
                String[] lines = File.ReadAllLines(ConfigPath);
                OsuPath = lines[0];
                BackupPath = lines[1];

                if (IsOsuFolder(OsuPath) && Directory.Exists(BackupPath))
                    // Return true only if all is correct and exists
                    return true;
            }
            catch { }
            return false;
        }

        public static void SaveConfiguration(String[] lines)
        {
            File.WriteAllLines(ConfigPath, lines);
        }

        private void browseosu_Click(object sender, EventArgs e)
        {
            Osubrowser.ShowDialog();
            if (Directory.Exists(Osubrowser.SelectedPath))
                osupath.Text = Osubrowser.SelectedPath; 
        }

        private void browsebackup_Click(object sender, EventArgs e)
        {
            Backupbrowser.ShowDialog();
            if (Directory.Exists(Backupbrowser.SelectedPath))
                savepath.Text = Backupbrowser.SelectedPath;
        }
    }
}
