using System;
using RickStore.StoreBusinessLogic;

namespace RickStore.StoreTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            InitializeInventory(inventory);
            var whatErinLikes = new Guitar("", 0, "fender", "Stratocastor", "electric", "Alder", "Alder");
            Guitar guitar = inventory.Search(whatErinLikes);
            if (guitar != null)
            {
                Console.WriteLine(guitar);
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
            Console.ReadLine();
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499, "Fender", "Stratocastor", "electric", "Alder", "Alder");
        }
    }
}
