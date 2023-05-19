using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.Service
{
	public interface IPassengerService
	{

		List<Tripgp> GetAllTrip();

		void DeleteRating(int id);

		void CreateRating(Rategp rategp);

		Tripgp GetTripByid(int id);

		Tripgp Search_A_Trip_by_Location(Tripgp tripgp);

		Tripgp Search_A_Trip_by_Price(Tripgp tripgp);

		Tripgp Search_A_Trip_by_Date(Tripgp tripgp);

		PassengerDTO Request_A_Trip(PassengerDTO passengerDTO);

		bool Is_Start(PassengerDTO passengerDTO);
	}
}



