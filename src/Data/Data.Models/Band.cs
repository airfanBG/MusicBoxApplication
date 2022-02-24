using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Band
    {
        public string Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 2)]
        public string BandName { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Song> Songs { get; set; }
    }
}
