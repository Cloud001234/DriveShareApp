using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Repository;
using DriveShareApp.Core.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Infra.Service
{
    public class CarOwnerService : ICarOwnerService
    {
        private readonly ICarOwnerRepository carOwnerRepository;

        public CarOwnerService(ICarOwnerRepository carOwnerRepository)
        {
            this.carOwnerRepository = carOwnerRepository;
        }
        //ddd

        public void acceptPassenger(Trippassengergp trippassengergp)
        {
            carOwnerRepository.acceptPassenger(trippassengergp);
        }

        public void activeCarOwner(CarOwnerDTO carOwnerDTO)
        {
            carOwnerRepository.activeCarOwner(carOwnerDTO);
        }

        public void activeTrip(Tripgp tripgp)
        {
            carOwnerRepository.activeTrip(tripgp);
        }

        public string checkCarOwner(Passengergp passengergp)
        {
           var r=carOwnerRepository.checkCarOwner(passengergp);

            if (r == null)
            {
                var tokenKeyValue = new Dictionary<string, int>
                {
                    { "carownerid", 0 }
                };

                string jsonResult = JsonConvert.SerializeObject(tokenKeyValue);
                return jsonResult;
            }
            else {
                var tokenKeyValue = new Dictionary<string, int>
                {
                    { "carownerid", (int)r }
                };
             string jsonResult = JsonConvert.SerializeObject(tokenKeyValue);
                return jsonResult;
            }

        }

        public void createTrip(Tripgp tripgp)
        {
            carOwnerRepository.createTrip(tripgp);
        }

        public void deleteCar(int id)
        {
            carOwnerRepository.deleteCar(id);        }

        public void deleteTrip(int id)
        {
            carOwnerRepository.deleteTrip(id);
        }

        public List<TripPasengerDTO> getAllAccept(TripPasengerDTO tripPasengerDTO)
        {
           return carOwnerRepository.getAllAccept(tripPasengerDTO);
        }

        public List<Passengergp> getAllPassenger()
        {
            return carOwnerRepository.getAllPassenger();
        }

        public List<TripPasengerDTO> getAllRequest(TripPasengerDTO tripPasengerDTO)
        {
            return carOwnerRepository.getAllRequest(tripPasengerDTO);
        }

        public List<Tripgp> getAllTrip()
        {
            return carOwnerRepository.getAllTrip();
        }

        public Passengergp getPassengerById(Passengergp passengergp)
        {
            return carOwnerRepository.getPassengerById(passengergp);
        }

        public TripPasengerDTO getRequestById(TripPasengerDTO tripPasengerDTO)
        {
            return carOwnerRepository.getRequestById(tripPasengerDTO);
        }

        public Tripgp getTripById(Tripgp tripgp)
        {
            return carOwnerRepository.getTripById(tripgp);      
        }

        public List<Tripgp> getTripCarOwner(Tripgp tripgp)
        {
            return carOwnerRepository.getTripCarOwner(tripgp);
        }

        public void updateCar(CarOwnerDTO carOwnerDTO)
        {
            carOwnerRepository.updateCar(carOwnerDTO);
        }

        public void updateTrip(Tripgp tripgp)
        {
            carOwnerRepository.updateTrip(tripgp);
        }

        public CarOwnerDTO getCar(CarOwnerDTO carOwnerDTO)
        {
            return carOwnerRepository.getCar(carOwnerDTO);
        }
    }
}
