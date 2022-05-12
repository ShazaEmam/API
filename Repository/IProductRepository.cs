using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface IProductRepository
    {
        int Delete(int id);
        List<Product> GetAll();
        List<Product> GetAllProductByCatId(int catId);
        Product GetById(int id);
        int Insert(Product prod);
        int Update(int id, Product prod);
    }
}