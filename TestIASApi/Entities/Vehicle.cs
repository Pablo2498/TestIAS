namespace TestIASApi.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public int Kilometers { get; set; }

        public int Price { get; set; }

        public Brand Brand { get; set; }
    }
}
