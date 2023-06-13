﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.DTOs
{
    public class UserDTO
    {
        public decimal Passengerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phonenumber { get; set; }
        public string Username { get; set; }

        public string Gender { get; set; }
        public string Imagefile { get; set; }
        public decimal? Carownerid { get; set; }
        public decimal Loginid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
