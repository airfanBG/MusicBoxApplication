using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Artist:BaseModel
    {
        public Artist()
        {
            ArtistSongs = new List<ArtistSong>();
        }
        [Required]
        [StringLength(20,MinimumLength = 2)]
        public string ArtistName { get; set; }
        [MaxLength(500)]
        public string Biography { get; set; }
        public List<ArtistSong> ArtistSongs { get; set; }

        public string? BandId { get; set; }
        public Band Band { get; set; }
    }
}
