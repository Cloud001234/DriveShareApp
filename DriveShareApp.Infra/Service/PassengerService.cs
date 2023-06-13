using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Repository;
using DriveShareApp.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Infra.Service
{
    public class PassengerService : IPassengerService
    {
        private readonly IPassengerRepository passengerRepository;

        public PassengerService(IPassengerRepository passengerRepository)
        {
            this.passengerRepository = passengerRepository;
        }
        public void CreateRating(Rategp rategp)
        {
            passengerRepository.CreateRating(rategp);
        }

        public void DeleteRating(int id)
        {
            passengerRepository.DeleteRating(id);
        }

        public List<Tripgp> GetAllTrip()
        {
            return passengerRepository.GetAllTrip();
        }

        public Tripgp GetTripByid(int id)
        {
            return passengerRepository.GetTripByid(id);
        }

        public void Is_Start(PassengerDTO passengerDTO)
        {
            passengerRepository.Is_Start(passengerDTO);
        }
        public void Is_Finish(PassengerDTO passengerDTO)
        {
            passengerRepository.Is_Finish(passengerDTO);
        }

        public void Request_A_Trip(PassengerDTO passengerDTO)
        {
            passengerRepository.Request_A_Trip(passengerDTO);
        }

        public List<Tripgp> Search_A_Trip_by_Date(Tripgp tripgp)
        {
            return passengerRepository.Search_A_Trip_by_Date(tripgp);
        }

        public List<Tripgp> Search_A_Trip_by_Location(Tripgp tripgp)
        {
            return passengerRepository.Search_A_Trip_by_Location(tripgp);
        }

        public List<Tripgp> Search_A_Trip_by_Price(Tripgp tripgp)
        {
            return passengerRepository.Search_A_Trip_by_Price(tripgp);
        }
        public List<TripPassengerGPDTO> MyTrip(TripPassengerGPDTO tripPassengerGPDTO)
        {
            return passengerRepository.MyTrip(tripPassengerGPDTO);
        }

    }
}
