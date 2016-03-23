namespace RickStore.StoreBusinessLogic
{
    public sealed class Guitar
    {
        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
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
        public string Builder { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public string BackWood { get; private set; }
        public string TopWood { get; private set; }
    }
}
