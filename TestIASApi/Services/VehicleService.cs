using TestIASApi.Dtos;
using TestIASApi.Entities;
using TestIASApi.Repositories.Interfaces;
using TestIASApi.Services.Interfaces;

namespace TestIASApi.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void AddVehicle(VehicleDTO vehicle)
        {
            try
            {
                _vehicleRepository.AddVehicle(new Vehicle
                {
                    Brand = new Brand { Name = vehicle.Brand.Name },
                    Description = vehicle.Description,
                    Kilometers = vehicle.Kilometers,
                    Model = vehicle.Model,
                    Price = vehicle.Price
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VehicleDTO> GetAllVehicles(int page, int items)
        {
            var vehicles = _vehicleRepository.GetAllVehicles(page, items);

            return vehicles.SelectMany(vehicle => new List<VehicleDTO>
            {
                new VehicleDTO 
                {
                    Brand = new BrandDTO { Name = vehicle.Brand.Name },
                    Description = vehicle.Description,
                    Kilometers = vehicle.Kilometers,
                    Model = vehicle.Model,
                    Price = vehicle.Price
                }
            }).ToList();
        }

        public VehicleDTO GetVehicleDetailById(int id)
        {
            var vehicle = _vehicleRepository.GetVehicleDetailById(id);

            return new VehicleDTO
            {
                Brand = new BrandDTO { Name = vehicle.Brand.Name },
                Price = vehicle.Price,
                Model = vehicle.Model,
                Description = vehicle.Description,
                Kilometers = vehicle.Kilometers
            };
        }
    }
}
