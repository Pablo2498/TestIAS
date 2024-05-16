using TestIASApi.Dtos;

namespace TestIASApi.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<List<VehicleDTO>> GetAllVehicles(int page, int items);

        Task<VehicleDTO> GetVehicleDetailById(int id);

        Task AddVehicle(VehicleDTO vehicle);
    }
}
