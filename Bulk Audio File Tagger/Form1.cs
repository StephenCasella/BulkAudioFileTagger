using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_Audio_File_Tagger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            status.Text = "Select files to tag";
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
            if (!string.IsNullOrWhiteSpace(files.Text))
            {
                status.Text = "Applying tags...";

                // todo: kick off thread to perform atting, do status updates, etc
            }
            else
            {
                status.Text = "No files selected";
            }
        }
    }
}
