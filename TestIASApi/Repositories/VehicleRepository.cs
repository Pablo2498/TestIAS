using Microsoft.EntityFrameworkCore;
using TestIASApi.Context;
using TestIASApi.Entities;
using TestIASApi.Repositories.Interfaces;

namespace TestIASApi.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;

        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddVehicle(Vehicle vehicle)
        {
            await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Vehicle>> GetAllVehicles(int page, int items)
        {
            return await _context.Vehicles.Skip((page - 1) * items).Take(items).Include(x => x.Brand).ToListAsync();
        }

        public async Task<Vehicle> GetVehicleDetailById(int id)
        {
            return await _context.Vehicles.Include(x => x.Brand)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
