using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Data
{
    public partial class Logingp
    {
        public decimal Loginid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Passengerid { get; set; }

        public virtual Passengergp Passenger { get; set; }
    }
}
