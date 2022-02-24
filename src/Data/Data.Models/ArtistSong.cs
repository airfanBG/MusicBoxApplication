using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ArtistSong
    {
        public string ArtistId { get; set; }
        public Artist Artist { get; set; }

        public string SongId { get; set; }
        public Song Song { get; set; }
    }
}
