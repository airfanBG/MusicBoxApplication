using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Band:BaseModel
    {
        public Band()
        {
            Artists = new List<Artist>();
            Songs=new List<Song>();
        }
        [Required]
        [StringLength(50,MinimumLength = 2)]
        public string BandName { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Song> Songs { get; set; }
    }
}
