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

        public void AddGuitar(string serialNumber, double price, Builder? builder, string model, GuitarType? type, Wood? backWood, Wood? topWood)
        {
            var guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return _guitars.FirstOrDefault(guitar => guitar.SerialNumber == serialNumber);
        }

        public List<Guitar> Search(Guitar searchGuitar)
        {
            var machingGuitars = new List<Guitar>();
            foreach (var guitar in _guitars)
            {
                Builder? builder = searchGuitar.Builder;
                if (builder.HasValue && builder != guitar.Builder)
                {
                    continue;
                }

                string model = searchGuitar.Model;
                if (!string.IsNullOrEmpty(model) && model != guitar.Model)
                {
                    continue;
                }

                GuitarType? type = searchGuitar.Type;
                if (type.HasValue && type != guitar.Type)
                {
                    continue;
                }

                Wood? backWood = searchGuitar.BackWood;
                if (backWood.HasValue && backWood != guitar.BackWood)
                {
                    continue;
                }

                Wood? topWood = searchGuitar.TopWood;
                if (topWood.HasValue && topWood != guitar.TopWood)
                {
                    continue;
                }

                machingGuitars.Add(guitar);
            }
            return machingGuitars;
        }
    }
}