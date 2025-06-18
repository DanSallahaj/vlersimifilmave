using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlersimiFilmave.BOL
{
    public class Film
    {
        public int ID { get; set; }
        public string Titulli { get; set; }
        public string? Regjisori { get; set; }
        public DateTime? Data_e_Publikimit { get; set; }
        public string? Zhanri { get; set; }
        public int? Vlersimi { get; set; }
    }
}
