using System;
using System.Collections.Generic;

#nullable disable

namespace DriveShareApp.Core.Data
{
    public partial class Cargp
    {
        public Cargp()
        {
            Carownergps = new HashSet<Carownergp>();
        }

        public decimal Carid { get; set; }
        public string Cartype { get; set; }
        public decimal? Carmodel { get; set; }
        public string Carmmodel { get; set; }
        public string Carnumber { get; set; }
        public string Imageliecnse { get; set; }

        public virtual ICollection<Carownergp> Carownergps { get; set; }
    }
}
