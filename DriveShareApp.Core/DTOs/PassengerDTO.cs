using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.DTOs
{
	public class  PassengerDTO
	{

        public decimal Passengerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phonenumber { get; set; }
        public string Username { get; set; }
        public string Imagefile { get; set; }
        public decimal? Carownerid { get; set; }


        public decimal Tripid { get; set; }
        public string Startingpoint { get; set; }
        public string Endingpoint { get; set; }
        public float Rideprice { get; set; }
        public DateTime Triptime { get; set; }
        public int Seatnumber { get; set; }
        public string Descreption { get; set; }
        public int IsActive { get; set; }
        public string SP1 { get; set; }
        public string SP2 { get; set; }
        public string SP3 { get; set; }
        public string SP4 { get; set; }

    }
}
