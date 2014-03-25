using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulk_Audio_File_Tagger
{
    class Tagger
    {

        public int TotalSongsToTag { get; private set; }
        public int TotalSongsTagged { get; private set; }

        public IList<string> SongsNotTagged { get; set; }

        private Form1.PerformGeneralUpdate progressUpdate = null;
        private Form1.PerformCompletionUpdate performCompletionUpdate = null;

        public Tagger(Form1.PerformGeneralUpdate progressUpdate, Form1.PerformCompletionUpdate performCompletionUpdate)
        {
            this.progressUpdate = progressUpdate;
            this.performCompletionUpdate = performCompletionUpdate;
        }

        public void ApplyTags(string[] files, uint year, string artist, string album, string contributingArtists)
        {
            try
            {
                if (files != null)
                {
                    TotalSongsTagged = 0;
                    TotalSongsToTag = files.Length;
                    SongsNotTagged = new List<string>();

                    // todo: parallelize this if necessary
                    foreach (string file in files)
                    {
                        try
                        {
                            TagLib.File song = TagLib.File.Create(file);
                            song.Tag.Title = Path.GetFileNameWithoutExtension(file);
                            song.Tag.Year = year;
                            song.Tag.AlbumArtists = new string[] { artist };
                            song.Tag.Performers = contributingArtists.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                            song.Tag.Album = album;
                            song.Save();
                            ++TotalSongsTagged;
                            progressUpdate();
                        }
                        catch (Exception)
                        {
                            SongsNotTagged.Add(file);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                performCompletionUpdate();
            }
        }
    }
}
