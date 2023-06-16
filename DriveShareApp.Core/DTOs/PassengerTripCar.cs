using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.DTOs
{
    public class PassengerTripCar
    {
        public decimal Passengerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phonenumber { get; set; }
        public string Username { get; set; }
        public string Imagefile { get; set; }
        public decimal? Carownerid { get; set; }
        public string Gender { get; set; }


        public string Startpoint { get; set; }
        public string Endpoint { get; set; }
        public decimal? Rideprice { get; set; }
        public DateTime? Triptime { get; set; }
        public decimal? Seatnumber { get; set; }
        public string Descreption { get; set; }
        public decimal? Isactive { get; set; }
        public string Sp1 { get; set; }
        public string Sp2 { get; set; }
        public string Sp3 { get; set; }
        public string Sp4 { get; set; }



        public string Cartype { get; set; }
        public decimal? Carmodel { get; set; }
        public string Carmmodel { get; set; }
        public string Carnumber { get; set; }
        public string Imageliecnse { get; set; }



    }
}
