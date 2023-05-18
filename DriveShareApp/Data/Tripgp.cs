using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Data
{
    public partial class Tripgp
    {
        public Tripgp()
        {
            Trippassengergps = new HashSet<Trippassengergp>();
        }

        public decimal Tripid { get; set; }
        public string Startpoint { get; set; }
        public string Endpoint { get; set; }
        public decimal? Rideprice { get; set; }
        public DateTime? Triptime { get; set; }
        public decimal? Seatnumber { get; set; }
        public string Descreption { get; set; }
        public decimal? Isactive { get; set; }
        public decimal? Carownerid { get; set; }
        public string Sp1 { get; set; }
        public string Sp2 { get; set; }
        public string Sp3 { get; set; }
        public string Sp4 { get; set; }

        public virtual Carownergp Carowner { get; set; }
        public virtual ICollection<Trippassengergp> Trippassengergps { get; set; }
    }
}
