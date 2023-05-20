using DriveShareApp.Core.Data;
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
    }
}
