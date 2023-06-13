using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.DTOs
{
    public class CarOwnerDTO
    {
        public decimal Passengerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phonenumber { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Imagefile { get; set; }
        public decimal? Carownerid { get; set; }
        public decimal Carid { get; set; }
        public string Cartype { get; set; }
        public decimal? Carmodel { get; set; }
        public string Carmmodel { get; set; }
        public string Carnumber { get; set; }
        public string Imageliecnse { get; set; }
        public string Drivelicense { get; set; }

    }
}
