using Dark.Net;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        string songs_folder;

        bool isSongPlaying = false;
        bool isSeeking = false;
        bool isSpotifyLikeShuffleEnabled = false;

        public Form1()
        {
            InitializeComponent();

            Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
            string formattedCV = $"{currentVersion.Major}.{currentVersion.Minor}.{currentVersion.Build}";
            this.Text = "OfflineMP3X - v" + formattedCV;
            
            spotifySeekBar1.ShowThumb = false;
            centerElements();

            if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
            {
                //Gives the titlebar dark mode
                DarkNet.Instance.SetWindowThemeForms(this, Theme.Auto);

                //making the form match the theme ig.
                this.BackColor = Color.FromArgb(25, 25, 25);
                this.ForeColor = Color.FromArgb(255, 255, 255);
                songinfopanel.BackColor = Color.FromArgb(35, 35, 35);
                songListBox.BackColor = Color.FromArgb(35, 35, 35);
                songListBox.ForeColor = Color.FromArgb(255, 255, 255);
                previous.FlatStyle = FlatStyle.Flat;
                playpause.FlatStyle = FlatStyle.Flat;
                next.FlatStyle = FlatStyle.Flat;
                settingsButton.FlatStyle = FlatStyle.Flat;
                aboutButton.FlatStyle = FlatStyle.Flat;
                shuffleButton.FlatStyle = FlatStyle.Flat;
                showHideListButton.FlatStyle = FlatStyle.Flat;
                previous.FlatAppearance.BorderSize = 0;
                playpause.FlatAppearance.BorderSize = 0;
                next.FlatAppearance.BorderSize = 0;
                settingsButton.FlatAppearance.BorderSize = 0;
                aboutButton.FlatAppearance.BorderSize = 0;
                shuffleButton.FlatAppearance.BorderSize = 0;
                previous.BackgroundImage = Image.FromFile(Application.StartupPath + "\\previous-button-icon-white.png");
                playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\play-button-icon-white.png");
                next.BackgroundImage = Image.FromFile(Application.StartupPath + "\\next-button-icon-white.png");
                settingsButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\settings-icon-white.png");
                aboutButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\about-form-icon-white.png");
                shuffleButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\shuffle-button-icon-white.png");
                this.Icon = new Icon(Application.StartupPath + "\\music-icon-white.ico");
                previous.Text = "";
                playpause.Text = "";
                next.Text = "";
                settingsButton.Text = "";
                aboutButton.Text = "";
                shuffleButton.Text = "";
            }
            else if (Properties.Settings.Default.THEME == "LIGHT")
            {
                //making the form match the theme ig.
                this.BackColor = Color.FromArgb(225, 225, 225);
                this.ForeColor = Color.FromArgb(0, 0, 0);
                songinfopanel.BackColor = Color.FromArgb(235, 235, 235);
                songListBox.BackColor = Color.FromArgb(235, 235, 235);
                songListBox.ForeColor = Color.FromArgb(0, 0, 0);
                previous.FlatStyle = FlatStyle.Flat;
                playpause.FlatStyle = FlatStyle.Flat;
                next.FlatStyle = FlatStyle.Flat;
                settingsButton.FlatStyle = FlatStyle.Flat;
                aboutButton.FlatStyle = FlatStyle.Flat;
                shuffleButton.FlatStyle = FlatStyle.Flat;
                showHideListButton.FlatStyle = FlatStyle.Flat;
                previous.FlatAppearance.BorderSize = 0;
                playpause.FlatAppearance.BorderSize = 0;
                next.FlatAppearance.BorderSize = 0;
                settingsButton.FlatAppearance.BorderSize = 0;
                aboutButton.FlatAppearance.BorderSize = 0;
                shuffleButton.FlatAppearance.BorderSize = 0;
                previous.BackgroundImage = Image.FromFile(Application.StartupPath + "\\previous-button-icon-black.png");
                playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\play-button-icon-black.png");
                next.BackgroundImage = Image.FromFile(Application.StartupPath + "\\next-button-icon-black.png");
                settingsButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\settings-icon-black.png");
                aboutButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\about-form-icon-black.png");
                shuffleButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\shuffle-button-icon-black.png");
                this.Icon = new Icon(Application.StartupPath + "\\music-icon-black.ico");
                previous.Text = "";
                playpause.Text = "";
                next.Text = "";
                settingsButton.Text = "";
                aboutButton.Text = "";
                shuffleButton.Text = "";
            }
            
            //random code
            songListBox.DrawMode = DrawMode.OwnerDrawFixed;
            songListBox.DrawItem += new DrawItemEventHandler(songListBox_DrawItem);

            isUpdatesOnStartupEnabled();
        }

        //Makes the listbox appearance match the theme of the form
        private void songListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
            {
                if (e.Index < 0) return;

                string itemText = songListBox.Items[e.Index].ToString();

                Color backgroundColor;
                Color foregroundColor;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    backgroundColor = Color.FromArgb(255, 255, 255);
                    foregroundColor = Color.FromArgb(0, 0, 0);
                }
                else
                {
                    backgroundColor = Color.FromArgb(35, 35, 35);
                    foregroundColor = Color.FromArgb(255, 255, 255);
                }

                e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                e.Graphics.DrawString(itemText, e.Font, new SolidBrush(foregroundColor), e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
            else if (Properties.Settings.Default.THEME == "LIGHT")
            {
                if (e.Index < 0) return;

                string itemText = songListBox.Items[e.Index].ToString();

                Color backgroundColor;
                Color foregroundColor;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    backgroundColor = Color.FromArgb(0, 0, 0);
                    foregroundColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    backgroundColor = Color.FromArgb(235, 235, 235);
                    foregroundColor = Color.FromArgb(0, 0, 0);
                }

                e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                e.Graphics.DrawString(itemText, e.Font, new SolidBrush(foregroundColor), e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        public void centerElements()
        {
            api.CenterPanel(controlsCB, 0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            centerElements();
            songinfopanel.Invalidate();

            if (WindowState == FormWindowState.Maximized)
            {
                pictureBox1.Size = new Size(432, 432);
                tracksNUMBER.Location = new Point(448, 12);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                pictureBox1.Size = new Size(232, 232);
                tracksNUMBER.Location = new Point(248, 12);
            }
        }

        private void songinfopanel_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Visible == false)
            {

            }
            else if (pictureBox1.Visible == true)
            {
                picBoxShadow(sender, e);
            }

            if (Properties.Settings.Default.ROUND_CORNERS_TOGGLE == false)
            {

            }
            else if (Properties.Settings.Default.ROUND_CORNERS_TOGGLE == true)
            {
                Panel panel = (Panel)sender;
                int radius = 25;

                panel.BorderStyle = BorderStyle.None;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.StartFigure();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    panel.Region = new Region(path);

                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.FromArgb(94, 94, 94), 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        public void picBoxShadow(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int shadowOffset = 4;
                Color shadowColor = Color.FromArgb(100, 0, 0, 0);

                Bitmap shadowImage = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format32bppArgb);
                using (Graphics gShadow = Graphics.FromImage(shadowImage))
                {
                    gShadow.FillRectangle(new SolidBrush(shadowColor), 0, 0, shadowImage.Width, shadowImage.Height);
                }

                Point shadowLocation = new Point(
                    pictureBox1.Location.X + shadowOffset,
                    pictureBox1.Location.Y + shadowOffset
                );

                e.Graphics.DrawImage(shadowImage, shadowLocation);
            }
        }

        public class Mp3Track
        {
            public string FilePath { get; set; }
            public int TrackNumber { get; set; }
            public string FileName => System.IO.Path.GetFileName(FilePath);
        }

        private void PopulateListBox(List<string> listBox, string folder)
        {
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
                listBox.Add(songs_folder + "\\" + Path.GetFileName(file));
        }

        List<string> initialList = new List<string>();
        List<Mp3Track> trackList = new List<Mp3Track>();

        public void sortList()
        {
            PopulateListBox(initialList, songs_folder);

            // 3. Extract track numbers (Requires TagLib# library)
            foreach (string path in initialList)
            {
                var tfile = TagLib.File.Create(path);
                trackList.Add(new Mp3Track
                {
                    FilePath = path,
                    // Default to 0 if track number tag is missing
                    TrackNumber = (int)tfile.Tag.Track
                });
            }

            // 4. Sort by TrackNumber
            var sortedTracks = trackList.OrderBy(t => t.TrackNumber).ToList();

            // 5. Add to ListBox
            songListBox.Items.Clear();
            foreach (var track in sortedTracks)
            {
                songListBox.Items.Add(track.FileName);
            }
        }

        #region Update Check on Startup
        private const string GitHubVersionFileUrl = "https://raw.githubusercontent.com/kristheredpanda/offlinemp3x/main/version.txt";
        public async void isUpdatesOnStartupEnabled()
        {
            if (Properties.Settings.Default.CHECK_FOR_UPDATES_ON_STARTUP == true)
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

        public void metadataCheck(string song_location)
        {
            TagLib.File file = TagLib.File.Create(song_location);
            label2.Text = file.Tag.Title;
            label3.Text = file.Tag.FirstPerformer;
            label4.Text = file.Tag.Album;
            
            int sm = file.Properties.Duration.Minutes;
            int ss = file.Properties.Duration.Seconds;

            if (ss < 10)
            {
                label6.Text = sm + ":0" + ss;
            }
            else if (ss == 10 || ss > 10)
            {
                label6.Text = sm + ":" + ss;
            }

            TagLib.IPicture picture = file.Tag.Pictures[0];
            byte[] bin = (byte[])(picture.Data.Data);

            using (MemoryStream ms = new MemoryStream(bin))
            {
                System.Drawing.Image albumArt = System.Drawing.Image.FromStream(ms);
                pictureBox1.Image = albumArt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SONG_FOLDER_DIR != "")
            {
                songs_folder = Properties.Settings.Default.SONG_FOLDER_DIR;
                sortList();
                songListBox.SelectedIndex = 0;
            }
            else if (Properties.Settings.Default.SONG_FOLDER_DIR == "")
            {
                noSongFolderSelectedTimer.Start();
            }
        }

        private void noSongFolderSelectedTimer_Tick(object sender, EventArgs e)
        {
            noSongFolderSelectedTimer.Stop();

            if (MessageBox.Show("It seems you have not yet selected a folder for this program to load songs from.\n\nClick 'OK' to select now.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Browse for Song Folder Location";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    songs_folder = fbd.SelectedPath;
                    sortList();
                    songListBox.SelectedIndex = 0;

                    Properties.Settings.Default.SONG_FOLDER_DIR = songs_folder;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private async void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string songpath = songs_folder + "\\" + songListBox.SelectedItem.ToString();
            int currenttracknumber = songListBox.SelectedIndex + 1;
            int totalsongs = songListBox.Items.Count;

            tracksNUMBER.Text = "Track " + currenttracknumber + " of " + totalsongs;

            metadataCheck(songpath);

            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(songpath);
            outputDevice.Init(audioFile);

            TagLib.File file = TagLib.File.Create(songs_folder + "\\" + songListBox.SelectedItem.ToString());

            int sm = file.Properties.Duration.Minutes;
            int ss = file.Properties.Duration.Seconds;
            int ts = (int)file.Properties.Duration.TotalSeconds;

            spotifySeekBar1.Maximum = ts;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (songListBox.Items.Count == 0)
            {

            }
            else
            {
                if (songListBox.SelectedIndex == 0)
                {
                    MessageBox.Show("You are at beginning of song list, cannot reverse any further.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    songTimer.Stop();
                    minutesBar.Value = 0;
                    secondsBar.Value = 0;
                    spotifySeekBar1.Value = 0;
                    label5.Text = minutesBar.Value + ":0" + secondsBar.Value;
                    outputDevice.Stop();

                    if (checkBoxRE.Checked == false)
                    {
                        outputDevice?.Dispose();
                        outputDevice = null;
                        audioFile?.Dispose();
                        audioFile = null;

                        songListBox.SelectedIndex--;
                    }
                    else if (checkBoxRE.Checked == true)
                    {
                        outputDevice?.Dispose();
                        outputDevice = null;
                        audioFile?.Dispose();
                        audioFile = null;

                        outputDevice = new WaveOutEvent();
                        audioFile = new AudioFileReader(songs_folder + "\\" + songListBox.SelectedItem.ToString());
                        outputDevice.Init(audioFile);
                    }

                    outputDevice.Play();
                    songTimer.Start();

                    if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
                    {
                        playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-white.png");
                    }
                    else if (Properties.Settings.Default.THEME == "LIGHT")
                    {
                        playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-black.png");
                    }
                }
            }
        }

        private void playpause_Click(object sender, EventArgs e)
        {
            if (songListBox.Items.Count == 0)
            {
                
            }
            else
            {
                if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
                {
                    if (isSongPlaying == false)
                    {
                        if (outputDevice.PlaybackState != PlaybackState.Playing)
                        {
                            outputDevice.Play();
                            playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-white.png");
                            isSongPlaying = true;
                            songTimer.Start();
                        }
                        else
                        {
                            outputDevice.Play();
                            playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-white.png");
                            isSongPlaying = true;
                            songTimer.Enabled = true;
                        }
                    }
                    else if (isSongPlaying == true)
                    {
                        outputDevice.Pause();
                        playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\play-button-icon-white.png");
                        isSongPlaying = false;
                        songTimer.Enabled = false;
                    }
                }
                else if (Properties.Settings.Default.THEME == "LIGHT")
                {
                    if (isSongPlaying == false)
                    {
                        if (outputDevice.PlaybackState != PlaybackState.Playing)
                        {
                            outputDevice.Play();
                            playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-black.png");
                            isSongPlaying = true;
                            songTimer.Start();
                        }
                        else
                        {
                            outputDevice.Play();
                            playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-black.png");
                            isSongPlaying = true;
                            songTimer.Enabled = true;
                        }
                    }
                    else if (isSongPlaying == true)
                    {
                        outputDevice.Pause();
                        playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\play-button-icon-black.png");
                        isSongPlaying = false;
                        songTimer.Enabled = false;
                    }
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (songListBox.Items.Count == 0)
            {

            }
            else
            {
                if (songListBox.SelectedIndex == songListBox.Items.Count - 1)
                {
                    MessageBox.Show("You are at end of song list, cannot go any further.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    songTimer.Stop();
                    
                    if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
                    {
                        playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-white.png");
                    }
                    else if (Properties.Settings.Default.THEME == "LIGHT")
                    {
                        playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pause-button-icon-black.png");
                    }

                    minutesBar.Value = 0;
                    secondsBar.Value = 0;
                    spotifySeekBar1.Value = 0;
                    label5.Text = minutesBar.Value + ":0" + secondsBar.Value;
                    outputDevice.Stop();

                    if (checkBoxRE.Checked == false)
                    {
                        outputDevice?.Dispose();
                        outputDevice = null;
                        audioFile?.Dispose();
                        audioFile = null;

                        if (isSpotifyLikeShuffleEnabled == true)
                        {
                            Random r = new Random();
                            songListBox.SelectedIndex = r.Next(0, songListBox.Items.Count - 1);
                        }
                        else if (isSpotifyLikeShuffleEnabled == false)
                        {
                            songListBox.SelectedIndex++;
                        }
                    }
                    else if (checkBoxRE.Checked == true)
                    {
                        outputDevice?.Dispose();
                        outputDevice = null;
                        audioFile?.Dispose();
                        audioFile = null;

                        outputDevice = new WaveOutEvent();
                        audioFile = new AudioFileReader(songs_folder + "\\" + songListBox.SelectedItem.ToString());
                        outputDevice.Init(audioFile);
                    }

                    outputDevice.Play();
                    songTimer.Start();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            TagLib.File file = TagLib.File.Create(songs_folder + "\\" + songListBox.SelectedItem.ToString());

            int sm = file.Properties.Duration.Minutes;
            int ss = file.Properties.Duration.Seconds;
            int ts = (int)file.Properties.Duration.TotalSeconds;

            spotifySeekBar1.Maximum = ts;

            // Get current song details and time from your music player
            string songTitle = file.Tag.Title;
            string artist = file.Tag.FirstPerformer;
            string album_name = file.Tag.Album;

            if (audioFile != null && !isSeeking)
            {
                spotifySeekBar1.Value = (int)audioFile.CurrentTime.TotalSeconds;

                if (secondsBar.Value < 10)
                {
                    label5.Text = minutesBar.Value + ":0" + secondsBar.Value;
                    secondsBar.Value = secondsBar.Value + 1;
                }
                else if (secondsBar.Value == 10 || secondsBar.Value > 10)
                {
                    label5.Text = minutesBar.Value + ":" + secondsBar.Value;
                    secondsBar.Value = secondsBar.Value + 1;
                }

                if (secondsBar.Value == 60)
                {
                    secondsBar.Value = 0;
                    minutesBar.Value = minutesBar.Value + 1;
                }
                else if (minutesBar.Value == sm && secondsBar.Value == ss)
                {
                    if (songListBox.SelectedIndex == songListBox.Items.Count - 1)
                    {
                        minutesBar.Value = 0;
                        secondsBar.Value = 0;
                        spotifySeekBar1.Value = 0;
                        label5.Text = "0:00";
                        songTimer.Stop();
                    }
                    else
                    {
                        outputDevice.Stop();
                        minutesBar.Value = 0;
                        secondsBar.Value = 0;
                        spotifySeekBar1.Value = 0;
                        label5.Text = "0:00";

                        if (checkBoxRE.Checked == false)
                        {
                            outputDevice?.Dispose();
                            outputDevice = null;
                            audioFile?.Dispose();
                            audioFile = null;

                            if (isSpotifyLikeShuffleEnabled == true)
                            {
                                Random r = new Random();
                                songListBox.SelectedIndex = r.Next(0, songListBox.Items.Count - 1);
                            }
                            else if (isSpotifyLikeShuffleEnabled == false)
                            {
                                songListBox.SelectedIndex++;
                            }
                        }
                        else if (checkBoxRE.Checked == true)
                        {
                            outputDevice?.Dispose();
                            outputDevice = null;
                            audioFile?.Dispose();
                            audioFile = null;

                            outputDevice = new WaveOutEvent();
                            audioFile = new AudioFileReader(songs_folder + "\\" + songListBox.SelectedItem.ToString());
                            outputDevice.Init(audioFile);
                        }

                        outputDevice.Play();
                    }
                }
            }
        }

        private void spotifySeekBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isSeeking = true;
            songTimer.Stop();
        }

        private void spotifySeekBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                // 1. Calculate new position based on percentage
                double percentage = (double)spotifySeekBar1.Value / spotifySeekBar1.Maximum;
                TimeSpan newPosition = TimeSpan.FromSeconds(percentage * audioFile.TotalTime.TotalSeconds);

                // 2. Set the position
                audioFile.CurrentTime = newPosition;

                minutesBar.Value = audioFile.CurrentTime.Minutes;
                secondsBar.Value = audioFile.CurrentTime.Seconds;

                if (secondsBar.Value < 10)
                {
                    label5.Text = minutesBar.Value + ":0" + secondsBar.Value;
                }
                else if (secondsBar.Value == 10 || secondsBar.Value > 10)
                {
                    label5.Text = minutesBar.Value + ":" + secondsBar.Value;
                }
            }

            isSeeking = false;
            songTimer.Start();
        }

        private void spotifySeekBar1_MouseHover(object sender, EventArgs e)
        {
            spotifySeekBar1.ShowThumb = true;
        }

        private void spotifySeekBar1_MouseLeave(object sender, EventArgs e)
        {
            spotifySeekBar1.ShowThumb = false;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            
            if (s.ShowDialog() == DialogResult.OK)
            {
                if (s.selectedTheme == "Dark (Default)")
                {
                    Properties.Settings.Default.THEME = "DARK_DEFAULT";
                    Properties.Settings.Default.Save();
                }
                else if (s.selectedTheme == "Light")
                {
                    Properties.Settings.Default.THEME = "LIGHT";
                    Properties.Settings.Default.Save();
                }

                if (s.updateCheckOnStartup == true)
                {
                    Properties.Settings.Default.CHECK_FOR_UPDATES_ON_STARTUP = true;
                    Properties.Settings.Default.Save();
                }
                else if (s.updateCheckOnStartup == false)
                {
                    Properties.Settings.Default.CHECK_FOR_UPDATES_ON_STARTUP = false;
                    Properties.Settings.Default.Save();
                }

                if (s.songFolderDestination == songs_folder)
                {

                }
                else if (s.songFolderDestination != "")
                {
                    Properties.Settings.Default.SONG_FOLDER_DIR = s.songFolderDestination;
                    Properties.Settings.Default.Save();

                    songTimer.Stop();
                    outputDevice.Stop();
                    outputDevice?.Dispose();
                    outputDevice = null;
                    audioFile?.Dispose();
                    audioFile = null;

                    pictureBox1.Image = null;
                    tracksNUMBER.Text = "";
                    label2.Text = "song name";
                    label3.Text = "song artist";
                    label4.Text = "song album";
                    label5.Text = "0:00";
                    spotifySeekBar1.Value = 0;
                    label6.Text = "0:00";
                    songListBox.Items.Clear();
                    sortList();
                    songListBox.SelectedIndex = 0;
                }

                if (s.enableRoundCorners == true)
                {
                    Properties.Settings.Default.ROUND_CORNERS_TOGGLE = true;
                    Properties.Settings.Default.Save();
                }
                else if (s.enableRoundCorners == false)
                {
                    Properties.Settings.Default.ROUND_CORNERS_TOGGLE = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (songListBox.Items.Count == 0)
            {
                MessageBox.Show("Shuffle cannot yet work as you haven't selected a folder to load songs from, go to the Settings form to select the folder then try again later with Shuffle.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Properties.Settings.Default.THEME == "DARK_DEFAULT")
                {
                    if (isSpotifyLikeShuffleEnabled == false)
                    {
                        isSpotifyLikeShuffleEnabled = true;
                        shuffleButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\shuffle-button-icon-green.png");
                    }
                    else if (isSpotifyLikeShuffleEnabled == true)
                    {
                        isSpotifyLikeShuffleEnabled = false;
                        shuffleButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\shuffle-button-icon-white.png");
                    }
                }
                else if (Properties.Settings.Default.THEME == "LIGHT")
                {
                    playpause.BackgroundImage = Image.FromFile(Application.StartupPath + "\\play-button-icon-black.png");

                    if (isSpotifyLikeShuffleEnabled == false)
                    {
                        isSpotifyLikeShuffleEnabled = true;
                        shuffleButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\shuffle-button-icon-green.png");
                    }
                    else if (isSpotifyLikeShuffleEnabled == true)
                    {
                        isSpotifyLikeShuffleEnabled = false;
                        shuffleButton.BackgroundImage = Image.FromFile(Application.StartupPath + "\\shuffle-button-icon-black.png");
                    }
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Properties.Settings.Default.ROUND_CORNERS_TOGGLE == false)
            {

            }
            else if (Properties.Settings.Default.ROUND_CORNERS_TOGGLE == true)
            {
                PictureBox pictureBox = (PictureBox)sender;
                int radius = 25;

                pictureBox.BorderStyle = BorderStyle.None;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.StartFigure();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(pictureBox.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(pictureBox.Width - radius, pictureBox.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, pictureBox.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    pictureBox.Region = new Region(path);

                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.FromArgb(94, 94, 94), 4))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private void showHideListButton_Click(object sender, EventArgs e)
        {
            if (songListBox.Visible == false)
            {
                songListBox.Visible = true;
                panel2.Visible = true;
                showHideListButton.Text = "Hide List";
                songinfopanel.Invalidate();
            }
            else if (songListBox.Visible == true)
            {
                songListBox.Visible = false;
                panel2.Visible = false;
                showHideListButton.Text = "Show List";
                songinfopanel.Invalidate();
            }
        }
    }

    public static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
