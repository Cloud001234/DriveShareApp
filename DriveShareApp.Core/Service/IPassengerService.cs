using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.Service
{
	public interface IPassengerService
	{

		List<PassengerTripCar> GetAllTrip();

		void DeleteRating(int id);

		void CreateRating(Rategp rategp);

		Tripgp GetTripByid(int id);

		List<PassengerTripCar> Search_A_Trip_by_Location(PassengerTripCar tripgp);

		List<Tripgp> Search_A_Trip_by_Price(Tripgp tripgp);

		List<Tripgp> Search_A_Trip_by_Date(Tripgp tripgp);

		void Request_A_Trip(PassengerDTO passengerDTO);

		void Is_Start(PassengerDTO passengerDTO);
		void Is_Finish(PassengerDTO passengerDTO);

		List<TripPassengerGPDTO> MyTrip(TripPassengerGPDTO tripPassengerGPDTO);

	}
}



