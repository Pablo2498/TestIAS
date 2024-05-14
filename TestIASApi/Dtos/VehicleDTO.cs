using TestIASApi.Entities;

namespace TestIASApi.Dtos
{
    public class VehicleDTO
    {
        public string Model { get; set; }

        public string Description { get; set; }

        public int Kilometers { get; set; }

        public int Price { get; set; }

        public BrandDTO Brand { get; set; }
    }
}
