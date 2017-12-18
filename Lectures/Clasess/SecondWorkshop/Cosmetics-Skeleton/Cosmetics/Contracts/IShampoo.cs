namespace Cosmetics.Contracts
{
    using Cosmetics.Common;

    public interface IShampoo : IProduct
    {
        uint Mililiters { get; }
        UsageType Usage { get; }
    }
}