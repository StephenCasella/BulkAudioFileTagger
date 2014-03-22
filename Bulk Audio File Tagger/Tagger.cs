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

        public void ApplyTags(string[] files, uint year, string artist, string album, string contributingArtists)
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
                        song.Tag.Performers = contributingArtists.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries);
                        song.Tag.Album = album;
                        song.Save();
                        ++TotalSongsTagged;
                    }
                    catch (Exception)
                    {
                        SongsNotTagged.Add(file);
                    }
                }
            }
        }
    }
}
