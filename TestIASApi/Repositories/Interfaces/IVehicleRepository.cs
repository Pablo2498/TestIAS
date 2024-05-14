using TestIASApi.Entities;

namespace TestIASApi.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles(int page, int items);

        Vehicle GetVehicleDetailById(int id);

        void AddVehicle(Vehicle vehicle);
    }
}
