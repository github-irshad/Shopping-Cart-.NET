using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.DataAccess;

namespace ShoppingCart.Service.Infrastructure
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int Id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void Save();
    }
}