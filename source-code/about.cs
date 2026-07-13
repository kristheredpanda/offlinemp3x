using Dark.Net;
using System;
using System.Drawing;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();

            if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
            {
                //Gives the titlebar dark mode
                DarkNet.Instance.SetWindowThemeForms(this, Theme.Auto);

                //making the form match the theme ig.
                this.BackColor = Color.FromArgb(25, 25, 25);
                this.ForeColor = Color.FromArgb(255, 255, 255);
                cfubutton.BackColor = Color.FromArgb(35, 35, 35);
                cfubutton.FlatStyle = FlatStyle.Flat;
                this.Icon = new Icon(Application.StartupPath + "\\music-icon-white.ico");
                this.Text = "About";
            }
            else if (Properties.Settings.Default.THEME == "LIGHT")
            {
                //making the form match the theme ig.
                this.BackColor = Color.FromArgb(225, 225, 225);
                this.ForeColor = Color.FromArgb(0, 0, 0);
                cfubutton.BackColor = Color.FromArgb(235, 235, 235);
                cfubutton.FlatStyle = FlatStyle.Flat;
                this.Icon = new Icon(Application.StartupPath + "\\music-icon-black.ico");
                this.Text = "About";
            }
        }

        private void about_Load(object sender, EventArgs e)
        {
            
        }

        #region Checking for updates manually
        private const string GitHubVersionFileUrl = "https://raw.githubusercontent.com/kristheredpanda/offlinemp3x/main/version.txt";
        private async void cfubutton_Click(object sender, EventArgs e)
        {
            try
            {
                Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                string formattedCV = $"{currentVersion.Major}.{currentVersion.Minor}.{currentVersion.Build}";
                Version latestVersion = await GetLatestVersionFromGitHub();
                string formattedLV = $"{latestVersion.Major}.{latestVersion.Minor}.{latestVersion.Build}";

                if (latestVersion != null && latestVersion > currentVersion)
                {
                    MessageBox.Show($"A new version ({formattedLV}) is available!\n\nCurrent version: {formattedCV}.\nPlease update.", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("https://github.com/kristheredpanda/offlinemp3x/releases");
                }
                else
                {
                    MessageBox.Show($"Your application is up to date.\nVersion: {formattedCV}", "No Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking for updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Version> GetLatestVersionFromGitHub()
        {
            using (HttpClient client = new HttpClient())
            {
                string versionString = await client.GetStringAsync(GitHubVersionFileUrl);
                return new Version(versionString.Trim());
            }
        }
        #endregion
    }
}
