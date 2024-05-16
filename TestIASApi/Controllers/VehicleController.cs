using Microsoft.AspNetCore.Mvc;
using TestIASApi.Dtos;
using TestIASApi.Models;
using TestIASApi.Services.Interfaces;

namespace TestIASApi.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("get-all-vehicles/{page}/{items}")]
        public async Task<Response> GetAllVehicles([FromRoute] int page, [FromRoute] int items)
        {
            return new Response
            {
                Data = await _vehicleService.GetAllVehicles(page, items),
                Message = "Ok",
                Status = 200
            };
        }

        [HttpGet("get-vehicle-detail/{id}")]
        public async Task<Response> GetVehicleDetail([FromRoute] int id)
        {
            return new Response
            {
                Data = await _vehicleService.GetVehicleDetailById(id),
                Message = "Ok",
                Status = 200
            };
        }

        [HttpPost("create-vehicle")]
        public async Task<Response> CreateVehicle(VehicleDTO vehicle)
        {
            await _vehicleService.AddVehicle(vehicle);
            return new Response
            {
                Data = vehicle,
                Message = "Created",
                Status = 201
            };
        }
    }
}
