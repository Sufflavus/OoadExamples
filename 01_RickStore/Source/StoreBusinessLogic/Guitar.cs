using RickStore.StoreBusinessLogic.Enums;

namespace RickStore.StoreBusinessLogic
{
    public sealed class Guitar
    {
        public override string ToString()
        {
            return $"SerialNumber: {SerialNumber}, Price: {Price}, Builder: {Builder}, Model: {Model}, Type: {Type}, BackWood: {BackWood}, TopWood: {TopWood}";
        }

        public Guitar(string serialNumber, double price, Builder? builder, string model, GuitarType? type, Wood? backWood, Wood? topWood)
        {
            SerialNumber = serialNumber;
            Price = price;
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public string SerialNumber { get; private set; }
        public double Price { get; set; }
        public Builder? Builder { get; private set; }
        public string Model { get; private set; }
        public GuitarType? Type { get; private set; }
        public Wood? BackWood { get; private set; }
        public Wood? TopWood { get; private set; }
    }
}
