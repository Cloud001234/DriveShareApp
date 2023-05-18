using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Data
{
    public partial class Carownergp
    {
        public Carownergp()
        {
            Passengergps = new HashSet<Passengergp>();
            Tripgps = new HashSet<Tripgp>();
        }

        public decimal Carownerid { get; set; }
        public string Drivelicense { get; set; }
        public decimal? Carid { get; set; }

        public virtual Cargp Car { get; set; }
        public virtual ICollection<Passengergp> Passengergps { get; set; }
        public virtual ICollection<Tripgp> Tripgps { get; set; }
    }
}
