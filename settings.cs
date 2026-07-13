using Dark.Net;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
            {
                //Gives the titlebar dark mode
                DarkNet.Instance.SetWindowThemeForms(this, Theme.Auto);

                //making the form match the theme ig.
                this.BackColor = Color.FromArgb(25, 25, 25);
                this.ForeColor = Color.FromArgb(255, 255, 255);
                okButton.BackColor = Color.FromArgb(35, 35, 35);
                cancelButton.BackColor = Color.FromArgb(35, 35, 35);
                SFLbrowsebutton.BackColor = Color.FromArgb(35, 35, 35);
                okButton.FlatStyle = FlatStyle.Flat;
                cancelButton.FlatStyle = FlatStyle.Flat;
                SFLbrowsebutton.FlatStyle = FlatStyle.Flat;
                this.Icon = new Icon(Application.StartupPath + "\\music-icon-white.ico");
                this.Text = "Settings";
            }
            else if (Properties.Settings.Default.THEME == "LIGHT")
            {
                //making the form match the theme ig.
                this.BackColor = Color.FromArgb(225, 225, 225);
                this.ForeColor = Color.FromArgb(0, 0, 0);
                okButton.BackColor = Color.FromArgb(235, 235, 235);
                cancelButton.BackColor = Color.FromArgb(235, 235, 235);
                SFLbrowsebutton.BackColor = Color.FromArgb(235, 235, 235);
                okButton.FlatStyle = FlatStyle.Flat;
                cancelButton.FlatStyle = FlatStyle.Flat;
                SFLbrowsebutton.FlatStyle |= FlatStyle.Flat;
                this.Icon = new Icon(Application.StartupPath + "\\music-icon-black.ico");
                this.Text = "Settings";
            }
        }

        public string selectedTheme
        {
            get { return themesComboBox.SelectedItem as string; }
        }

        public bool updateCheckOnStartup
        {
            get { return checkBoxUOS.Checked; }
        }

        public string songFolderDestination
        {
            get { return textBoxSFL.Text; }
        }

        public bool enableRoundCorners
        {
            get { return checkBoxRC.Checked; }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
            {
                themesComboBox.SelectedIndex = 0;
                settingChangedWarning.Visible = false;
            }
            else if (Properties.Settings.Default.THEME == "LIGHT")
            {
                themesComboBox.SelectedIndex = 1;
                settingChangedWarning.Visible = false;
            }

            if (Properties.Settings.Default.CHECK_FOR_UPDATES_ON_STARTUP == true)
            {
                checkBoxUOS.Checked = true;
                settingChangedWarning.Visible = false;
            }
            else if (Properties.Settings.Default.CHECK_FOR_UPDATES_ON_STARTUP == false)
            {
                checkBoxUOS.Checked = false;
            }

            if (Properties.Settings.Default.ROUND_CORNERS_TOGGLE == true)
            {
                checkBoxRC.Checked = true;
                settingChangedWarning.Visible = false;
            }
            else if (Properties.Settings.Default.ROUND_CORNERS_TOGGLE == false)
            {
                checkBoxRC.Checked = false;
            }

            if (Properties.Settings.Default.SONG_FOLDER_DIR != "")
            {
                textBoxSFL.Text = Properties.Settings.Default.SONG_FOLDER_DIR;
            }
        }

        private void themesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingChangedWarning.Visible = true;
        }

        private void SFLbrowsebutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Browse for Song Folder Location";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxSFL.Text = fbd.SelectedPath;
            }
        }

        private void checkBoxRC_CheckedChanged(object sender, EventArgs e)
        {
            settingChangedWarning.Visible = true;
        }
    }
}
