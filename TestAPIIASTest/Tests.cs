using TestIASApi.Entities;
using TestIASApi.Repositories;

namespace TestAPIIASTest
{
    public class Tests
    {
        public Vehicle VehicleTest { get; set; }

        [SetUp]
        public void Setup()
        {
            VehicleTest = new Vehicle
            {
                Id = 1,
                Description = "Test",
                Kilometers = 134,
                Model = "2012",
                Price = 1033,
                Brand = new Brand { Id = 1, Name = "Mazda" }
            };
        }

        [Test]
        public void GetVehicleByIdMethod_ReturnsVehicle()
        {
            var repo = new VehicleRepository();

            repo.AddVehicle(VehicleTest);
            var vehicle = repo.GetVehicleDetailById(1);

            Assert.AreEqual(VehicleTest.Id, vehicle.Id);
            Assert.AreEqual(VehicleTest.Price, vehicle.Price);
        }
    }


}