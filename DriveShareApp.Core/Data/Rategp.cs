using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Core.Data
{
    public partial class Rategp
    {
        public Rategp()
        {
            Trippassengergps = new HashSet<Trippassengergp>();
        }

        public decimal Rateid { get; set; }
        public decimal? Ratenumber { get; set; }
        public string Ratedesc { get; set; }

        public virtual ICollection<Trippassengergp> Trippassengergps { get; set; }
    }
}
