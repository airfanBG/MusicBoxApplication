using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Song:BaseModel
    {
        public Song()
        {
            ArtistSongs = new List<ArtistSong>();
        }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string SongName { get; set; }
        public int Seconds { get; set; }
        public int ReleaseDate { get; set; }

        public List<ArtistSong> ArtistSongs { get; set; }
        public string? BandId { get; set; }
        public Band Band { get; set; }
    }
}
