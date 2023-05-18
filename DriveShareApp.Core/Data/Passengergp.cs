using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Core.Data
{
    public partial class Passengergp
    {
        public Passengergp()
        {
            Logingps = new HashSet<Logingp>();
            Trippassengergps = new HashSet<Trippassengergp>();
        }

        public decimal Passengerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phonenumber { get; set; }
        public string Username { get; set; }
        public string Imagefile { get; set; }
        public decimal? Carownerid { get; set; }

        public virtual Carownergp Carowner { get; set; }
        public virtual ICollection<Logingp> Logingps { get; set; }
        public virtual ICollection<Trippassengergp> Trippassengergps { get; set; }
    }
}
