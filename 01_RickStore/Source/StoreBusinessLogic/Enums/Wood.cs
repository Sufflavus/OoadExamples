using System.ComponentModel;

namespace RickStore.StoreBusinessLogic.Enums
{
    public enum Wood
    {
        [Description("Indian Rosewood")]
        IndianRosewood = 0,

        [Description("Brazilian Rosewood")]
        BrazilianRosewood = 1,

        [Description("Mahogany")]
        Mahogany = 2,

        [Description("Maple")]
        Maple = 3,

        [Description("Cocobolo")]
        Cocobolo = 4,

        [Description("Cedar")]
        Cedar = 5,

        [Description("Adirondack")]
        Adirondack = 6,

        [Description("Alder")]
        Alder = 7,

        [Description("Sitka")]
        Sitka = 8
    }
}