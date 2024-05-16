using TestIASApi.Entities;

namespace TestIASApi.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        Task<List<Vehicle>> GetAllVehicles(int page, int items);

        Task<Vehicle> GetVehicleDetailById(int id);

        Task AddVehicle(Vehicle vehicle);
    }
}
