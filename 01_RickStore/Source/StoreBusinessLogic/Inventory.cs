using System.Collections.Generic;
using System.Linq;

namespace RickStore.StoreBusinessLogic
{
    public sealed class Inventory
    {
        private readonly List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type,
            string backWood, string topWood)
        {
            var guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return _guitars.FirstOrDefault(guitar => guitar.SerialNumber == serialNumber);
        }

        public Guitar Search(Guitar searchGuitar)
        {
            foreach (var guitar in _guitars)
            {
                string builder = searchGuitar.Builder;
                if (!string.IsNullOrEmpty(builder) && builder != guitar.Builder)
                {
                    continue;
                }

                string model = searchGuitar.Model;
                if (!string.IsNullOrEmpty(model) && model != guitar.Model)
                {
                    continue;
                }

                string type = searchGuitar.Type;
                if (!string.IsNullOrEmpty(type) && type != guitar.Type)
                {
                    continue;
                }

                string backWood = searchGuitar.BackWood;
                if (!string.IsNullOrEmpty(backWood) && backWood != guitar.BackWood)
                {
                    continue;
                }

                string topWood = searchGuitar.TopWood;
                if (!string.IsNullOrEmpty(topWood) && topWood != guitar.TopWood)
                {
                    continue;
                }

                return guitar;
            }
            return null;
        }
    }
}