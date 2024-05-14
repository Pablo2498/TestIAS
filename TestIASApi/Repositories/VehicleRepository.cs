using TestIASApi.Entities;
using TestIASApi.Repositories.Interfaces;

namespace TestIASApi.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicle.Id = GetNextFreeId();
            Vehicles.Add(vehicle);
        }

        public List<Vehicle> GetAllVehicles(int page, int items)
        {
            return Vehicles.Skip((page - 1) * items).Take(items).ToList();
        }

        public Vehicle GetVehicleDetailById(int id)
        {
            return Vehicles.Find(t => t.Id.Equals(id));
        }

        private int GetNextFreeId()
        {
            if (Vehicles.Count == 0) 
                return 1;
            int maxId = Vehicles.Max(t => t.Id);
            return maxId++;
        }
    }
}
