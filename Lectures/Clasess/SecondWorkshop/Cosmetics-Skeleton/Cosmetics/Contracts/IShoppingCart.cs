using Cosmetics.Contracts;
using System.Collections.Generic;

namespace Cosmetics.Contracts
{
    public interface IShoppingCart
    {
        
        void RemoveProduct(IProduct product);
        decimal TotalPrice();
        void AddProduct(IProduct product);
        bool ContainsProduct(IProduct product);

        // Which methods should be here?
        // Write them
    }
}