namespace WindowsFormsApp2
{
    partial class settings
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.themesComboBox = new System.Windows.Forms.ComboBox();
            this.settingChangedWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUOS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSFL = new System.Windows.Forms.TextBox();
            this.SFLbrowsebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(517, 305);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(64, 24);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(586, 305);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theme";
            // 
            // themesComboBox
            // 
            this.themesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themesComboBox.FormattingEnabled = true;
            this.themesComboBox.Items.AddRange(new object[] {
            "Dark (Default)",
            "Light"});
            this.themesComboBox.Location = new System.Drawing.Point(13, 46);
            this.themesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.themesComboBox.Name = "themesComboBox";
            this.themesComboBox.Size = new System.Drawing.Size(125, 21);
            this.themesComboBox.TabIndex = 3;
            this.themesComboBox.SelectedIndexChanged += new System.EventHandler(this.themesComboBox_SelectedIndexChanged);
            // 
            // settingChangedWarning
            // 
            this.settingChangedWarning.AutoSize = true;
            this.settingChangedWarning.Location = new System.Drawing.Point(10, 290);
            this.settingChangedWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingChangedWarning.Name = "settingChangedWarning";
            this.settingChangedWarning.Size = new System.Drawing.Size(335, 39);
            this.settingChangedWarning.TabIndex = 4;
            this.settingChangedWarning.Text = "Changes have been made that require this application to be restarted,\r\nclick \'OK\'" +
    " to save the changes, then stop the music and close then\r\nre-open the applicatio" +
    "n.";
            this.settingChangedWarning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Update";
            // 
            // checkBoxUOS
            // 
            this.checkBoxUOS.AutoSize = true;
            this.checkBoxUOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUOS.Location = new System.Drawing.Point(13, 108);
            this.checkBoxUOS.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUOS.Name = "checkBoxUOS";
            this.checkBoxUOS.Size = new System.Drawing.Size(210, 21);
            this.checkBoxUOS.TabIndex = 6;
            this.checkBoxUOS.Text = "Check for updates on startup";
            this.checkBoxUOS.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Song Folder Location";
            // 
            // textBoxSFL
            // 
            this.textBoxSFL.Location = new System.Drawing.Point(13, 167);
            this.textBoxSFL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSFL.Name = "textBoxSFL";
            this.textBoxSFL.ReadOnly = true;
            this.textBoxSFL.Size = new System.Drawing.Size(291, 20);
            this.textBoxSFL.TabIndex = 8;
            // 
            // SFLbrowsebutton
            // 
            this.SFLbrowsebutton.Location = new System.Drawing.Point(13, 191);
            this.SFLbrowsebutton.Margin = new System.Windows.Forms.Padding(2);
            this.SFLbrowsebutton.Name = "SFLbrowsebutton";
            this.SFLbrowsebutton.Size = new System.Drawing.Size(76, 21);
            this.SFLbrowsebutton.TabIndex = 9;
            this.SFLbrowsebutton.Text = "Browse";
            this.SFLbrowsebutton.UseVisualStyleBackColor = true;
            this.SFLbrowsebutton.Click += new System.EventHandler(this.SFLbrowsebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Misc";
            // 
            // checkBoxRC
            // 
            this.checkBoxRC.AutoSize = true;
            this.checkBoxRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRC.Location = new System.Drawing.Point(379, 46);
            this.checkBoxRC.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRC.Name = "checkBoxRC";
            this.checkBoxRC.Size = new System.Drawing.Size(179, 21);
            this.checkBoxRC.TabIndex = 12;
            this.checkBoxRC.Text = "Round Corners (kind of)";
            this.checkBoxRC.UseVisualStyleBackColor = true;
            this.checkBoxRC.CheckedChanged += new System.EventHandler(this.checkBoxRC_CheckedChanged);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 339);
            this.Controls.Add(this.checkBoxRC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SFLbrowsebutton);
            this.Controls.Add(this.textBoxSFL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxUOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingChangedWarning);
            this.Controls.Add(this.themesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox themesComboBox;
        private System.Windows.Forms.Label settingChangedWarning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxUOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSFL;
        private System.Windows.Forms.Button SFLbrowsebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxRC;
    }
}