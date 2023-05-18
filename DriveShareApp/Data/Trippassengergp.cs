using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Data
{
    public partial class Trippassengergp
    {
        public decimal Tpid { get; set; }
        public decimal? Request { get; set; }
        public decimal? Tripid { get; set; }
        public decimal? Passengerid { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? IsStarted { get; set; }

        public virtual Passengergp Passenger { get; set; }
        public virtual Rategp Rate { get; set; }
        public virtual Tripgp Trip { get; set; }
    }
}
