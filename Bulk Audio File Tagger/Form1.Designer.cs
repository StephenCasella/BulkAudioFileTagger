namespace Bulk_Audio_File_Tagger
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
            this.label1 = new System.Windows.Forms.Label();
            this.files = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tagButton = new System.Windows.Forms.Button();
            this.contributingArtists = new System.Windows.Forms.TextBox();
            this.ablumArtists = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.album = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.statusBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files to Tag";
            // 
            // files
            // 
            this.files.Location = new System.Drawing.Point(82, 13);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(409, 20);
            this.files.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(497, 13);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.status,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 210);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(587, 22);
            this.statusBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 181);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(555, 23);
            this.progressBar.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contributingArtists);
            this.groupBox1.Controls.Add(this.ablumArtists);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.album);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Contributing Artists";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Album Artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // tagButton
            // 
            this.tagButton.Location = new System.Drawing.Point(17, 152);
            this.tagButton.Name = "tagButton";
            this.tagButton.Size = new System.Drawing.Size(555, 23);
            this.tagButton.TabIndex = 6;
            this.tagButton.Text = "Apply Tags";
            this.tagButton.UseVisualStyleBackColor = true;
            this.tagButton.Click += new System.EventHandler(this.tagButton_Click);
            // 
            // contributingArtists
            // 
            this.contributingArtists.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bulk_Audio_File_Tagger.Properties.Settings.Default, "ContributingArtists", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contributingArtists.Location = new System.Drawing.Point(346, 49);
            this.contributingArtists.Name = "contributingArtists";
            this.contributingArtists.Size = new System.Drawing.Size(199, 20);
            this.contributingArtists.TabIndex = 4;
            this.contributingArtists.Text = global::Bulk_Audio_File_Tagger.Properties.Settings.Default.ContributingArtists;
            // 
            // ablumArtists
            // 
            this.ablumArtists.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bulk_Audio_File_Tagger.Properties.Settings.Default, "AlbumArtist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ablumArtists.Location = new System.Drawing.Point(346, 20);
            this.ablumArtists.Name = "ablumArtists";
            this.ablumArtists.Size = new System.Drawing.Size(199, 20);
            this.ablumArtists.TabIndex = 2;
            this.ablumArtists.Text = global::Bulk_Audio_File_Tagger.Properties.Settings.Default.AlbumArtist;
            // 
            // year
            // 
            this.year.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bulk_Audio_File_Tagger.Properties.Settings.Default, "Year", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.year.Location = new System.Drawing.Point(41, 49);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(199, 20);
            this.year.TabIndex = 3;
            this.year.Text = global::Bulk_Audio_File_Tagger.Properties.Settings.Default.Year;
            // 
            // album
            // 
            this.album.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bulk_Audio_File_Tagger.Properties.Settings.Default, "Album", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.album.Location = new System.Drawing.Point(41, 74);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(199, 20);
            this.album.TabIndex = 5;
            this.album.Text = global::Bulk_Audio_File_Tagger.Properties.Settings.Default.Album;
            // 
            // title
            // 
            this.title.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bulk_Audio_File_Tagger.Properties.Settings.Default, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title.Location = new System.Drawing.Point(41, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 20);
            this.title.TabIndex = 1;
            this.title.Text = global::Bulk_Audio_File_Tagger.Properties.Settings.Default.Title;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 232);
            this.Controls.Add(this.tagButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.files);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bulk Audio File Tagger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox files;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox album;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contributingArtists;
        private System.Windows.Forms.TextBox ablumArtists;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tagButton;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

