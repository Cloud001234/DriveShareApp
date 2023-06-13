using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.DTOs
{
    public class TripPassengerGPDTO
    {
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
        public decimal Tpid { get; set; }
        public decimal? Request { get; set; }
        public decimal? Passengerid { get; set; }
        public decimal? Rateid { get; set; }
        public decimal? IsStarted { get; set; }
    }
}
