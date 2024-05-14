using TestIASApi.Dtos;

namespace TestIASApi.Services.Interfaces
{
    public interface IVehicleService
    {
        List<VehicleDTO> GetAllVehicles(int page, int items);

        VehicleDTO GetVehicleDetailById(int id);

        void AddVehicle(VehicleDTO vehicle);
    }
}
