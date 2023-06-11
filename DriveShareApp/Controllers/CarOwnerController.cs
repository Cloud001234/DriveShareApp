using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
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
    public class CarOwnerController : ControllerBase
    {
        private readonly ICarOwnerService carOwnerService;

        public CarOwnerController(ICarOwnerService carOwnerService)
        {
            this.carOwnerService = carOwnerService;
        }

        [HttpGet("getalltrip")]
        public List<Tripgp> getAllTrip()
        {
            return carOwnerService.getAllTrip();
        }

        [HttpGet("getallpassenger")]
        public List<Passengergp> getAllPassenger()
        {
            return carOwnerService.getAllPassenger();
        }

        [HttpPost("getpassengerbyid")]
        public Passengergp getPassengerById(Passengergp passengergp)
        {
            return carOwnerService.getPassengerById(passengergp);
        }

        [HttpPost("createtrip")]
        public void createTrip(Tripgp tripgp)
        {
            carOwnerService.createTrip(tripgp);
        }

        [HttpPut("updatetrip")]
        public void updateTrip(Tripgp tripgp)
        {
            carOwnerService.updateTrip(tripgp);
        }

        [HttpDelete("deletetrip")]
        public void deleteTrip(Tripgp tripgp)
        {
            carOwnerService.deleteTrip(Convert.ToInt32(tripgp.Tripid));
        }

        [HttpPost("gettripbyid")]
        public Tripgp getTripById(Tripgp tripgp)
        {
            return carOwnerService.getTripById(tripgp);
        }

        [HttpPut("activetrip")]
        public void activeTrip(Tripgp tripgp)
        {
            carOwnerService.activeTrip(tripgp);
        }

        [HttpPost("checkcarowner")]
        public string checkCarOwner(Passengergp passengergp)
        {
            return carOwnerService.checkCarOwner(passengergp);
        }

        [HttpPost("activecarowner")]
        public void activeCarOwner(CarOwnerDTO carOwnerDTO)
        {
            carOwnerService.activeCarOwner(carOwnerDTO);
        }
        
        [HttpPut("updatecar")]
        public void updateCar(CarOwnerDTO carOwnerDTO)
        {
            carOwnerService.updateCar(carOwnerDTO);
        }
        [HttpDelete("deletecar")]
        public void deleteCar(CarOwnerDTO carOwnerDTO)
        {
            carOwnerService.deleteCar(Convert.ToInt32(carOwnerDTO.Passengerid));
        }

        [HttpPost("gettallrequest")]
        public List<TripPasengerDTO> getAllRequest(TripPasengerDTO tripPasengerDTO)
        {
            return carOwnerService.getAllRequest(tripPasengerDTO);
        }

        [HttpPost("gettallaccept")]
        public List<TripPasengerDTO> getAllAccept(TripPasengerDTO tripPasengerDTO)
        {
            return carOwnerService.getAllAccept(tripPasengerDTO);
        }

        [HttpPost("acceptpassenger")]
        public void acceptPassenger(Trippassengergp trippassengergp)
        {
            carOwnerService.acceptPassenger(trippassengergp);
        }

        [HttpPost("getrequestbyid")]
        public TripPasengerDTO getRequestById(TripPasengerDTO tripPasengerDTO)
        {
            return carOwnerService.getRequestById(tripPasengerDTO);
        }

        [HttpPost("gettripscarowner")]
        public List<Tripgp> getTripCarOwner(Tripgp tripgp)
        {
            return carOwnerService.getTripCarOwner(tripgp);
        }
    }
}
