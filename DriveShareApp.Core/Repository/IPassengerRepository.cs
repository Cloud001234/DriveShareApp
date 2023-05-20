using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.Repository
{
	
	public interface IPassengerRepository
	{

		List<Tripgp> GetAllTrip();

		void DeleteRating(int id);

		void CreateRating(Rategp rategp);

		Tripgp GetTripByid(int id);

		List<Tripgp> Search_A_Trip_by_Location(Tripgp tripgp);

		List<Tripgp> Search_A_Trip_by_Price(Tripgp tripgp);

		List<Tripgp> Search_A_Trip_by_Date(Tripgp tripgp);

		void Request_A_Trip(PassengerDTO passengerDTO);

		void Is_Start(PassengerDTO passengerDTO);



	}
}
