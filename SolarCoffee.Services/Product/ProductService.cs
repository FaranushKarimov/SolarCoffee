using SolarCoffee.Data;
using SolarCoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarCoffee.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly SolarDbContext _db;
        public ProductService(SolarDbContext dbContext)
        {
            _db = dbContext;
        }
        public ServiceResponse<bool> ArchiveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<bool> CreateProduct(Data.Models.Product product)
        {
            _db.Products.Add(product);
            var newInventory = new ProductInventory()
            {

            };
            _db.SaveChanges();
            return new ServiceResponse<bool>
            {

            };
        }

        public List<Data.Models.Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }

        public Data.Models.Product GetProductById(int id)
        {
            return _db.Products.Find(id);
        }
    }
}
