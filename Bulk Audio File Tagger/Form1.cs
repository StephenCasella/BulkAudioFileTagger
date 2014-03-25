using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bulk_Audio_File_Tagger.Properties;

namespace Bulk_Audio_File_Tagger
{
    public partial class Form1 : Form
    {


        public delegate void PerformGeneralUpdate();
        public delegate void PerformCompletionUpdate();
        private delegate void ProgressBarUpdate();
        private delegate void PerformTaggingComplete();
        private delegate void PerformStatusUpdate();

        private PerformTaggingComplete PerformTaggingCompleteImplementation = null;
        private ProgressBarUpdate ProgressBarUpdateImplementation = null;
        private PerformStatusUpdate PerformStatusUpdateImplementation = null;
        private PerformGeneralUpdate DoGeneralUpdate = null;
        private PerformCompletionUpdate DoCompletionUpdate = null;

        Tagger tagger = null;

        public Form1()
        {
            InitializeComponent();
            status.Text = "Select files to tag";
            PerformTaggingCompleteImplementation = TaggingCompleteButton;
            ProgressBarUpdateImplementation = UpdateProgressBar;
            PerformStatusUpdateImplementation = UpdateStatus;
            DoGeneralUpdate = GeneralUpdate;
            DoCompletionUpdate = CompletionUpdate;
            tagger = new Tagger(DoGeneralUpdate, DoCompletionUpdate);
        }

        private void CompletionUpdate()
        {
            try
            {
                InvokeTaggingComplete();
            }
            catch (Exception) { }
        }

        private void GeneralUpdate()
        {
            try
            {
                InvokeUpdateProgressBar();
            }
            catch (Exception) { }
            try
            {
                InvokeUpdateStatus();
            }
            catch (Exception) { }
        }

        private void UpdateStatus()
        {
            if (progressBar.Maximum == progressBar.Value)
            {
                status.Text = "Finished";
            }
            else if (tagger.SongsNotTagged.Count + tagger.TotalSongsTagged == tagger.TotalSongsToTag && 
                tagger.SongsNotTagged.Any())
            {
                status.Text = "Failed";
            }
        }

        private void InvokeUpdateStatus()
        {
            statusBar.Invoke(PerformStatusUpdateImplementation);
        }

        private void UpdateProgressBar()
        {
            progressBar.Maximum = tagger.TotalSongsToTag;
            progressBar.Minimum = 0;
            progressBar.Value = tagger.TotalSongsTagged + tagger.SongsNotTagged.Count;
        }

        private void InvokeUpdateProgressBar()
        {
            progressBar.Invoke(ProgressBarUpdateImplementation);
        }

        private void InvokeTaggingComplete()
        {
            tagButton.Invoke(PerformTaggingCompleteImplementation);
            InvokeUpdateProgressBar();
        }

        private void TaggingCompleteButton()
        {
            tagButton.Enabled = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "MP3 Files (*.mp3) | *.mp3";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    files.Text = string.Join(",", dialog.FileNames);
                    status.Text = "Enter your tag data and hit the apply button";
                    title.Focus();
                }

            }

        }

        private void tagButton_Click(object sender, EventArgs e)
        {
            saveSettings();
            if (!string.IsNullOrWhiteSpace(files.Text))
            {
                uint yearInt;

                if (uint.TryParse(year.Text, out yearInt)) {

                    status.Text = "Applying tags...";
                    tagButton.Enabled = false;

                    new Thread(() =>
                    {
                        try
                        {
                            tagger.ApplyTags(files.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries),
                                yearInt, ablumArtists.Text, album.Text, contributingArtists.Text);

                            if (tagger.SongsNotTagged.Count > 0)
                            {
                                StringBuilder errorText = new StringBuilder();

                                errorText.AppendLine("The following songs were not successfully tagged:").AppendLine();

                                foreach (string song in tagger.SongsNotTagged)
                                {
                                    errorText.AppendLine(Path.GetFileName(song));
                                }

                                errorText.AppendLine().AppendLine("Please try again.");

                                MessageBox.Show(errorText.ToString(), "Error");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                    }).Start();

                }
                else 
                {
                    status.Text = "Invalid year";
                }
            }
            else
            {
                status.Text = "No files selected";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void saveSettings()
        {
            Settings.Default.Save();
        }


    }
}
