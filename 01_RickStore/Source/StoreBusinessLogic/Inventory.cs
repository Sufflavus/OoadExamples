using System.Collections.Generic;
using System.Linq;
using RickStore.StoreBusinessLogic.Enums;

namespace RickStore.StoreBusinessLogic
{
    public sealed class Inventory
    {
        private readonly List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, Builder? builder, string model, GuitarType? type, int numStrings, Wood? backWood, Wood? topWood)
        {
            var spec = new GuitarSpec(builder, model, type, numStrings, backWood, topWood);
            var guitar = new Guitar(serialNumber, price, spec);
            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return _guitars.FirstOrDefault(guitar => guitar.SerialNumber == serialNumber);
        }

        public List<Guitar> Search(GuitarSpec searchGuitar)
        {
            var machingGuitars = new List<Guitar>();
            foreach (var guitar in _guitars)
            {
                GuitarSpec guitarSpec = guitar.Spec;
                if (guitarSpec.Matches(searchGuitar))
                {
                    machingGuitars.Add(guitar);
                }
            }
            return machingGuitars;
        }
    }
}