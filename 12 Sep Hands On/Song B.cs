using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPT_12_HANDS_ON
{
    [Developer("New Album", SongName = "Innum enna thozha")]
    public class Song
    {
        [Developer("Name of the song", SongName = "Innum Enna Thozha")]
        public string SongName { get; set; }

        [Developer("Language of the song", Language = "Tamil")]
        public string Language { get; set; }

        [Developer("Lyrics", Lyrics = "abc")]

        [Developer("Language of the song", Language = "Tamil")]
        public string Lyrics { get; set; }


        public Song(string sname, string language, string lyrics)
        {
            SongName = sname;
            Language = language;
            Lyrics = lyrics;
        }
    }
}
