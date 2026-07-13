namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.songinfopanel = new System.Windows.Forms.Panel();
            this.tracksNUMBER = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songListBox = new System.Windows.Forms.ListBox();
            this.previous = new System.Windows.Forms.Button();
            this.playpause = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.songTimer = new System.Windows.Forms.Timer(this.components);
            this.minutesBar = new System.Windows.Forms.ProgressBar();
            this.secondsBar = new System.Windows.Forms.ProgressBar();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.noSongFolderSelectedTimer = new System.Windows.Forms.Timer(this.components);
            this.shuffleButton = new System.Windows.Forms.Button();
            this.checkBoxRE = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.controlsCB = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.showHideListButton = new System.Windows.Forms.Button();
            this.spotifySeekBar1 = new WindowsFormsApp2.SpotifySeekBar();
            this.songinfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.controlsCB.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spotifySeekBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // songinfopanel
            // 
            this.songinfopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songinfopanel.Controls.Add(this.showHideListButton);
            this.songinfopanel.Controls.Add(this.tracksNUMBER);
            this.songinfopanel.Controls.Add(this.pictureBox1);
            this.songinfopanel.Controls.Add(this.label4);
            this.songinfopanel.Controls.Add(this.label3);
            this.songinfopanel.Controls.Add(this.label2);
            this.songinfopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songinfopanel.Location = new System.Drawing.Point(4, 4);
            this.songinfopanel.Margin = new System.Windows.Forms.Padding(2);
            this.songinfopanel.Name = "songinfopanel";
            this.songinfopanel.Size = new System.Drawing.Size(669, 418);
            this.songinfopanel.TabIndex = 2;
            this.songinfopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.songinfopanel_Paint);
            // 
            // tracksNUMBER
            // 
            this.tracksNUMBER.AutoSize = true;
            this.tracksNUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracksNUMBER.Location = new System.Drawing.Point(248, 12);
            this.tracksNUMBER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tracksNUMBER.Name = "tracksNUMBER";
            this.tracksNUMBER.Size = new System.Drawing.Size(84, 17);
            this.tracksNUMBER.TabIndex = 4;
            this.tracksNUMBER.Text = "Track 0 of 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "song album";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "song artist";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "song name";
            // 
            // songListBox
            // 
            this.songListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.songListBox.Enabled = false;
            this.songListBox.FormattingEnabled = true;
            this.songListBox.Location = new System.Drawing.Point(690, 4);
            this.songListBox.Margin = new System.Windows.Forms.Padding(2);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(271, 418);
            this.songListBox.TabIndex = 3;
            this.songListBox.Visible = false;
            this.songListBox.SelectedIndexChanged += new System.EventHandler(this.songListBox_SelectedIndexChanged);
            // 
            // previous
            // 
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous.Location = new System.Drawing.Point(224, 0);
            this.previous.Margin = new System.Windows.Forms.Padding(2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(30, 30);
            this.previous.TabIndex = 4;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // playpause
            // 
            this.playpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playpause.Location = new System.Drawing.Point(305, 0);
            this.playpause.Margin = new System.Windows.Forms.Padding(2);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(30, 30);
            this.playpause.TabIndex = 5;
            this.playpause.Text = "Play";
            this.playpause.UseVisualStyleBackColor = true;
            this.playpause.Click += new System.EventHandler(this.playpause_Click);
            // 
            // next
            // 
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(382, 0);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(30, 30);
            this.next.TabIndex = 6;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "0:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "0:00";
            // 
            // songTimer
            // 
            this.songTimer.Interval = 1000;
            this.songTimer.Tick += new System.EventHandler(this.songTimer_Tick);
            // 
            // minutesBar
            // 
            this.minutesBar.Location = new System.Drawing.Point(114, 20);
            this.minutesBar.Margin = new System.Windows.Forms.Padding(2);
            this.minutesBar.Name = "minutesBar";
            this.minutesBar.Size = new System.Drawing.Size(38, 19);
            this.minutesBar.TabIndex = 10;
            this.minutesBar.Visible = false;
            // 
            // secondsBar
            // 
            this.secondsBar.Location = new System.Drawing.Point(114, 51);
            this.secondsBar.Margin = new System.Windows.Forms.Padding(2);
            this.secondsBar.Name = "secondsBar";
            this.secondsBar.Size = new System.Drawing.Size(38, 19);
            this.secondsBar.TabIndex = 11;
            this.secondsBar.Visible = false;
            // 
            // aboutButton
            // 
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(96, 20);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(34, 37);
            this.aboutButton.TabIndex = 13;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(47, 20);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(34, 37);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // noSongFolderSelectedTimer
            // 
            this.noSongFolderSelectedTimer.Interval = 1000;
            this.noSongFolderSelectedTimer.Tick += new System.EventHandler(this.noSongFolderSelectedTimer_Tick);
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.Location = new System.Drawing.Point(0, 20);
            this.shuffleButton.Margin = new System.Windows.Forms.Padding(2);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(34, 37);
            this.shuffleButton.TabIndex = 15;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // checkBoxRE
            // 
            this.checkBoxRE.AutoSize = true;
            this.checkBoxRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRE.Location = new System.Drawing.Point(24, 29);
            this.checkBoxRE.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRE.Name = "checkBoxRE";
            this.checkBoxRE.Size = new System.Drawing.Size(73, 21);
            this.checkBoxRE.TabIndex = 16;
            this.checkBoxRE.Text = "Repeat";
            this.checkBoxRE.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.songinfopanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.songListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(965, 426);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(673, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 418);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.controlsCB);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.minutesBar);
            this.panel4.Controls.Add(this.secondsBar);
            this.panel4.Controls.Add(this.checkBoxRE);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 81);
            this.panel4.TabIndex = 21;
            // 
            // controlsCB
            // 
            this.controlsCB.Controls.Add(this.label5);
            this.controlsCB.Controls.Add(this.playpause);
            this.controlsCB.Controls.Add(this.label6);
            this.controlsCB.Controls.Add(this.previous);
            this.controlsCB.Controls.Add(this.spotifySeekBar1);
            this.controlsCB.Controls.Add(this.next);
            this.controlsCB.Location = new System.Drawing.Point(189, 0);
            this.controlsCB.Name = "controlsCB";
            this.controlsCB.Size = new System.Drawing.Size(604, 81);
            this.controlsCB.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.shuffleButton);
            this.panel6.Controls.Add(this.aboutButton);
            this.panel6.Controls.Add(this.settingsButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(846, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 81);
            this.panel6.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(1005, 466);
            this.panel5.TabIndex = 22;
            // 
            // showHideListButton
            // 
            this.showHideListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showHideListButton.Location = new System.Drawing.Point(561, 12);
            this.showHideListButton.Name = "showHideListButton";
            this.showHideListButton.Size = new System.Drawing.Size(91, 36);
            this.showHideListButton.TabIndex = 5;
            this.showHideListButton.Text = "Show List";
            this.showHideListButton.UseVisualStyleBackColor = true;
            this.showHideListButton.Click += new System.EventHandler(this.showHideListButton_Click);
            // 
            // spotifySeekBar1
            // 
            this.spotifySeekBar1.AutoSize = false;
            this.spotifySeekBar1.Location = new System.Drawing.Point(36, 41);
            this.spotifySeekBar1.Margin = new System.Windows.Forms.Padding(2);
            this.spotifySeekBar1.Name = "spotifySeekBar1";
            this.spotifySeekBar1.ShowThumb = true;
            this.spotifySeekBar1.Size = new System.Drawing.Size(532, 16);
            this.spotifySeekBar1.TabIndex = 17;
            this.spotifySeekBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.spotifySeekBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spotifySeekBar1_MouseDown);
            this.spotifySeekBar1.MouseLeave += new System.EventHandler(this.spotifySeekBar1_MouseLeave);
            this.spotifySeekBar1.MouseHover += new System.EventHandler(this.spotifySeekBar1_MouseHover);
            this.spotifySeekBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spotifySeekBar1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 547);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1021, 586);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.songinfopanel.ResumeLayout(false);
            this.songinfopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.controlsCB.ResumeLayout(false);
            this.controlsCB.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spotifySeekBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel songinfopanel;
        private System.Windows.Forms.ListBox songListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button playpause;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer songTimer;
        private System.Windows.Forms.ProgressBar minutesBar;
        private System.Windows.Forms.ProgressBar secondsBar;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label tracksNUMBER;
        private System.Windows.Forms.Timer noSongFolderSelectedTimer;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.CheckBox checkBoxRE;
        private SpotifySeekBar spotifySeekBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel controlsCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button showHideListButton;
    }
}

