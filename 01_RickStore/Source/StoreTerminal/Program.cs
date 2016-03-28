using System;
using System.Collections.Generic;
using System.Linq;
using RickStore.StoreBusinessLogic;
using RickStore.StoreBusinessLogic.Enums;

namespace RickStore.StoreTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            InitializeInventory(inventory);

            var whatErinLikes = new Guitar("", 0, Builder.Fender, "Stratocastor", GuitarType.Electric, Wood.Alder, Wood.Alder);

            List<Guitar> guitars = inventory.Search(whatErinLikes);
            if (guitars.Any())
            {
                guitars.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
            Console.ReadLine();
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499.95, Builder.Fender, "Stratocastor", GuitarType.Electric, Wood.Alder, Wood.Alder);
            inventory.AddGuitar("V9512", 1549.95, Builder.Fender, "Stratocastor", GuitarType.Electric, Wood.Alder, Wood.Alder);
        }
    }
}
