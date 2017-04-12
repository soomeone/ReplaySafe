namespace ReplaySafe
{
    partial class Configuration
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
            this.osupath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseosu = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Backupbrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Osubrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.browsebackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.savepath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // osupath
            // 
            this.osupath.Location = new System.Drawing.Point(93, 6);
            this.osupath.Name = "osupath";
            this.osupath.Size = new System.Drawing.Size(194, 20);
            this.osupath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osu! path:";
            // 
            // browseosu
            // 
            this.browseosu.Location = new System.Drawing.Point(293, 4);
            this.browseosu.Name = "browseosu";
            this.browseosu.Size = new System.Drawing.Size(27, 23);
            this.browseosu.TabIndex = 2;
            this.browseosu.Text = "...";
            this.browseosu.UseVisualStyleBackColor = true;
            this.browseosu.Click += new System.EventHandler(this.browseosu_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(245, 61);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // browsebackup
            // 
            this.browsebackup.Location = new System.Drawing.Point(293, 33);
            this.browsebackup.Name = "browsebackup";
            this.browsebackup.Size = new System.Drawing.Size(27, 23);
            this.browsebackup.TabIndex = 6;
            this.browsebackup.Text = "...";
            this.browsebackup.UseVisualStyleBackColor = true;
            this.browsebackup.Click += new System.EventHandler(this.browsebackup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Backup path:";
            // 
            // savepath
            // 
            this.savepath.Location = new System.Drawing.Point(93, 35);
            this.savepath.Name = "savepath";
            this.savepath.Size = new System.Drawing.Size(194, 20);
            this.savepath.TabIndex = 4;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 100);
            this.Controls.Add(this.browsebackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savepath);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.browseosu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osupath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Configuration";
            this.Text = "ReplaySafe Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox osupath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseosu;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FolderBrowserDialog Backupbrowser;
        private System.Windows.Forms.FolderBrowserDialog Osubrowser;
        private System.Windows.Forms.Button browsebackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox savepath;
    }
}