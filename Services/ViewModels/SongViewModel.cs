using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels
{
    public class SongViewModel:BaseViewModel
    {
        public string SongName { get; set; }
        public int Seconds { get; set; }
        public int ReleaseDate { get; set; }
    }
}
