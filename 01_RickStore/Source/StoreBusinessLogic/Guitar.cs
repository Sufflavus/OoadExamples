using RickStore.StoreBusinessLogic.Enums;

namespace RickStore.StoreBusinessLogic
{
    public sealed class Guitar
    {
        public override string ToString()
        {
            return $"SerialNumber: {SerialNumber}, Price: {Price}, Spec: {Spec}";
        }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }

        public string SerialNumber { get; }

        public double Price { get; }

        public GuitarSpec Spec { get; }
    }
}
