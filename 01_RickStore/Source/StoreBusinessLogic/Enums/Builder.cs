using System.ComponentModel;

namespace RickStore.StoreBusinessLogic.Enums
{
    public enum Builder
    {
        [Description("Fender")]
        Fender = 0,

        [Description("Martin")]
        Martin = 1,

        [Description("Gibson")]
        Gibson = 2,

        [Description("Collings")]
        Collings = 3,

        [Description("Olson")]
        Olson = 4,

        [Description("Ryan")]
        Ryan = 5,

        [Description("Prs")]
        Prs = 6,

        [Description("Any")]
        Any = 7
    }
}