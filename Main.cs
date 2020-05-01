using HLVR_SDK_Assistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HLVR_SDK_Assistant
{
    public partial class Main : Form
    {
        private string sdkMapPath = "";
        private string gameMapPath = "";
        private string sdkScriptPath = "";
        private string sdkScriptStartPath = "";
        private string gameScriptPath = "";
        private string gameScriptStartPath = "";
        private int numSelection = 0;
        private int num = 0;
        private List<string> mapNames = new List<string>();

        public Main()
        {

            InitializeComponent();
            toolStripStatusMapSelectLabel.Text = "No Maps Selected";
            toolStripStatusMapsLoadedLabel.Text = "No Maps Found";
            /*
             *  I am going to add saving the paths to the registry so the user doesn't need
             *  set them every time the program launches.
             * 
            if ()
            {

            }
            else
            {

            }
            */

        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sdkMapBrowseButton_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog sdkMapBrowseDialog = new FolderBrowserDialog();
            if (sdkMapBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                sdkMapPath = sdkMapBrowseDialog.SelectedPath;
                sdkMapPathText.Text = sdkMapPath;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (gameMapPathText.Text == "")
            {
                MessageBox.Show("Please select an output destination!", "Error");
            }
            else
            {
                try
                {
                    foreach (string map in mapNames)
                    {
                        File.Copy(Path.Combine(sdkMapPath, map), Path.Combine(gameMapPath, map), true);
                    }
                    MessageBox.Show("The selected maps were copied!", "Info");
                }
                catch (Exception a)
                {
                    MessageBox.Show("An error occured while copying maps: " + a.Message, "Error");
                }
            }
            
        }

        private void sdkMapPathMapCheck(object sender, EventArgs e)
        {

            mapNames.Clear();
            mapListBox.Items.Clear();
            num = 0;

            string filepath = sdkMapPath;
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach(var file in d.GetFiles("*.vpk"))
            {
                mapNames.Add(file.ToString());
                num = num + 1;
                mapListBox.Items.Add(file.Name);
            }

            switch (num)
            {
                case 0:
                    toolStripStatusMapsLoadedLabel.Text = "No Maps Found";
                    break;

                default:
                    toolStripStatusMapsLoadedLabel.Text = "Maps Loaded: " + num.ToString();
                    break;
            }
        }

        private void updateSelection(object sender, ItemCheckEventArgs e)
        {
            mapNames.Clear();

            // updateSelection runs before the handler updates the CheckedItems collection.
            // Therefore, we must handle the update after the event is over.
            // https://stackoverflow.com/a/32291665
            this.BeginInvoke(new Action(() =>
            {
                Console.WriteLine(mapListBox.CheckedItems.Count);
                numSelection = mapListBox.CheckedItems.Count;

                foreach (string mapSelection in mapListBox.CheckedItems)
                {
                    mapNames.Add(mapSelection);
                }

                switch (numSelection)
                {
                    case 0:
                        toolStripStatusMapSelectLabel.Text = "No Maps Selected";
                        // If no maps are selected, disable the "copy maps" button
                        mapCopyButton.Enabled = false;
                        break;

                    case 1:
                        toolStripStatusMapSelectLabel.Text = numSelection.ToString() + " Map Selected.";
                        mapCopyButton.Enabled = true;
                        break;

                    default:
                        toolStripStatusMapSelectLabel.Text = numSelection.ToString() + " Maps Selected.";
                        mapCopyButton.Enabled = true;
                        break;
                }
            }));
        }

        private void gameMapBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog gameMapBrowseDialog = new FolderBrowserDialog();
            if (gameMapBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                gameMapPath = gameMapBrowseDialog.SelectedPath;
                gameMapPathText.Text = gameMapPath;
            }
        }

        private void sdkScriptBrowseButton_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog sdkScriptBrowseDialog = new OpenFileDialog();
                sdkScriptBrowseDialog.Filter = "Batch Scripts (*.bat)|*.bat|All Files (*.*)|*.*";
                sdkScriptBrowseDialog.Title = "Open the SDK script batch file";
                if (sdkScriptBrowseDialog.ShowDialog() == DialogResult.OK)
                {
                    sdkScriptPath = sdkScriptBrowseDialog.FileName;
                    sdkScriptStartPath = Path.GetDirectoryName(sdkScriptPath);
                    sdkScriptText.Text = sdkScriptPath;
                }
            }
        }

        private void gameScriptBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog gameScriptBrowseDialog = new OpenFileDialog();
            gameScriptBrowseDialog.Filter = "Batch Scripts (*.bat)|*.bat|Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            gameScriptBrowseDialog.Title = "Open the game executable or batch file";
            if (gameScriptBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                gameScriptPath = gameScriptBrowseDialog.FileName;
                gameScriptStartPath = Path.GetDirectoryName(gameScriptPath);
                gameScriptText.Text = gameScriptPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo();
                startInfo.WorkingDirectory = sdkScriptStartPath;
                startInfo.FileName = sdkScriptPath;
                Process sdkScript = Process.Start(startInfo);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                MessageBox.Show("An error occured while launching the SDK: " + a.Message,"Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo();
                startInfo.WorkingDirectory = gameScriptStartPath;
                startInfo.FileName = gameScriptPath;
                Process gameScript = Process.Start(startInfo);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                MessageBox.Show("An error occured while launching the game: " + a.Message,"Error");
            }
        }

        private void refreshMapList(object sender, EventArgs e)
        {
            mapNames.Clear();
            num = 0;
            string filepath = sdkMapPath;
            mapListBox.Items.Clear();
            mapCopyButton.Enabled = false;
            toolStripStatusMapSelectLabel.Text = "No Maps Selected";

            try
            {
                DirectoryInfo d = new DirectoryInfo(filepath);
                foreach (var file in d.GetFiles("*.vpk"))
                {
                    mapNames.Add(file.ToString());
                    num = num + 1;
                    mapListBox.Items.Add(file.Name);

                    switch (num)
                    {
                        case 0:
                            toolStripStatusMapsLoadedLabel.Text = "No Maps Found";
                            break;

                        default:
                            toolStripStatusMapsLoadedLabel.Text = "Maps Loaded: " + num.ToString();
                            break;
                    }
                }
            }

            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                MessageBox.Show("An error occured while refreshing the map list: " + a.Message, "Error");
            }
        }
    }
}
