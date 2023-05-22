﻿using DriveShareApp.Core.Data;
using DriveShareApp.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveShareApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PassengerController : ControllerBase
	{
		private readonly IPassengerService passengerService;

		public PassengerController(IPassengerService passengerService)
		{
			this.passengerService = passengerService;
		}

        [HttpGet("getalltrip")]
        public List<Tripgp> GetAllTrip()
        {
            return passengerService.GetAllTrip();
        }

        [HttpDelete("deleterating/{id}")]
        public void DeleteRating(int id)
        {
            passengerService.DeleteRating(id);
        }

        [HttpPost("createrating")]
        public void CreateRating([FromBody] Rategp rategp)
        {
            if (rategp != null)
            {
                passengerService.CreateRating(rategp);
            }
        }

        [HttpGet("gettripbyid/{id}")]
        public Tripgp GetTripById(int id)
        {
            return passengerService.GetTripByid(id);
        }

        [HttpPost("searchbylocation")]
        public List<Tripgp> SearchTripByLocation([FromBody] Tripgp tripgp)
        {
            return passengerService.Search_A_Trip_by_Location(tripgp);
        }

        [HttpPost("searchbyprice")]
        public List<Tripgp> SearchTripByPrice([FromBody] Tripgp tripgp)
        {
            return passengerService.Search_A_Trip_by_Price(tripgp);
        }

        [HttpPost("searchbydate")]
        public List<Tripgp> SearchTripByDate([FromBody] Tripgp tripgp)
        {
            return passengerService.Search_A_Trip_by_Date(tripgp);
        }
        [HttpPost("requesttrip")]
        public void RequestTrip([FromBody] PassengerDTO passengerDTO)
        {
            if (passengerDTO != null)
            {
                passengerService.Request_A_Trip(passengerDTO);
            }
        }

        [HttpPost("isstart")]
        public void IsStart([FromBody] PassengerDTO passengerDTO)
        {
            if (passengerDTO != null)
            {
                passengerService.Is_Start(passengerDTO);
            }
        }






    }
}


