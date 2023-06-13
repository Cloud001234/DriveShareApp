using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.Service
{
    public interface ICarOwnerService
    {
        List<Passengergp> getAllPassenger();
        Passengergp getPassengerById(Passengergp passengergp);
        void createTrip(Tripgp tripgp);
        void updateTrip(Tripgp tripgp);
        void deleteTrip(int id);
        List<Tripgp> getAllTrip();
        Tripgp getTripById(Tripgp tripgp);
        void activeTrip(Tripgp tripgp);
        void finishTrip(Tripgp tripgp);
        string checkCarOwner(Passengergp passengergp);
        //create car and carowner
        void activeCarOwner(CarOwnerDTO carOwnerDTO);
        //update car and carowner details
        void updateCar(CarOwnerDTO carOwnerDTO);
        void deleteCar(int id);
        List<TripPasengerDTO> getAllRequest(TripPasengerDTO tripPasengerDTO);
        List<TripPasengerDTO> getAllAccept(TripPasengerDTO tripPasengerDTO);
        void acceptPassenger(Trippassengergp trippassengergp);
        TripPasengerDTO getRequestById(TripPasengerDTO tripPasengerDTO);
        List<Tripgp> getTripCarOwner(Tripgp tripgp);
        CarOwnerDTO getCar(CarOwnerDTO carOwnerDTO);

        Passengergp getCarowner(Passengergp passengergp);

    }
}
